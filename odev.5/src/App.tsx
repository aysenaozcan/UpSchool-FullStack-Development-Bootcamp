
import React, { useState } from 'react';
import './App.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSort, faTrashAlt } from '@fortawesome/free-solid-svg-icons';



type Todo = {
  id: number;
  text: string;
  completed: boolean;
};

const TodoList: React.FC = () => {
  const [todos, setTodos] = useState<Todo[]>([]);
  const [newTodo, setNewTodo] = useState<string>('');
  const [sortByDate, setSortByDate] = useState<boolean>(false); // State for sorting by date

  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setNewTodo(event.target.value);
  };

  const handleAddTodo = () => {
    if (newTodo.trim() === '') {
      return;
    }

    const todo: Todo = {
      id: Date.now(),
      text: newTodo,
      completed: false,
    };

    setTodos([...todos, todo]);
    setNewTodo('');
  };

  const handleToggleTodo = (id: number) => {
    const updatedTodos = todos.map((todo) => {
      if (todo.id === id) {
        return { ...todo, completed: !todo.completed };
      }
      return todo;
    });
    setTodos(updatedTodos);
  };

  const handleDeleteTodo = (id: number) => {
    const updatedTodos = todos.filter((todo) => todo.id !== id);
    setTodos(updatedTodos);
  };

  const handleSortByDate = () => {
    setSortByDate(!sortByDate);
    const sortedTodos = [...todos].sort((a, b) => {
      if (sortByDate) {
        return a.id - b.id; // Sort in ascending order based on id (oldest first)
      } else {
        return b.id - a.id; // Sort in descending order based on id (newest first)
      }
    });
    setTodos(sortedTodos);
  };

  const handleDoubleClickTodo = (id: number) => {
    const updatedTodos = todos.map((todo) => {
      if (todo.id === id) {
        return { ...todo, completed: !todo.completed };
      }
      return todo;
    });
    setTodos(updatedTodos);
  };

  return (
    <div>
      <h1>Todo List</h1>
      <div>
        <input type="text" value={newTodo} onChange={handleInputChange} placeholder="You must enter at least one character" />
        
        <button onClick={handleAddTodo} disabled={!newTodo.trim()}>
          Add
        </button>
        <div></div>
        
      </div>
      <h2>You can mark the solved todos by double clicking</h2>
      <button onClick={handleSortByDate}>
          Sort by Date {sortByDate ? '▲' : '▼'}
        </button>
      <ul>
        {todos.map((todo) => (
          <li
            key={todo.id}
            onDoubleClick={() => handleDoubleClickTodo(todo.id)}
            style={{ textDecoration: todo.completed ? 'line-through' : 'none' }}
          >
            <input
              type="checkbox"
              checked={todo.completed}
              onChange={() => handleToggleTodo(todo.id)}
            />
           
            <span >{todo.text}</span>
          
            <button style={{ display: 'inline-block' }} onClick={() => handleDeleteTodo(todo.id)} className="delete-button"> 
            <span className="delete-button"></span>
              <FontAwesomeIcon icon={faTrashAlt} className="delete-icon" />
            </button>
            
            
          </li>
        ))}
      </ul>
    </div>
  );
};

export default TodoList;






