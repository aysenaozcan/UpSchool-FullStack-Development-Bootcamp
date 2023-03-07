
using PasswordGenerator;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

Console.WriteLine("------------------------------------WELCOME TO PASSWORD MANAGER----------------------------------");
Console.WriteLine("******************If you are response is yes press to y otherwise press to n*********************");

Console.WriteLine("Do you want to include numbers");
var isNumberStatus = Console.ReadLine(); //We keep the answers.

Console.WriteLine("Ok! How about lowercase characters?");
var isLowerCharStatus = Console.ReadLine();

Console.WriteLine("Very nice! How about uppercase characters?");
var isUpperCharStatus = Console.ReadLine();

Console.WriteLine("All right! We are almost done. Would you also want to add  special characters?");
var isSpecialCharStatus = Console.ReadLine();

Console.WriteLine("Graet! Lastly, how long do you  want to keep your password length?");
int isPasswordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("It is time to PASSWORD =>");

//Strings containing characters are defined.
String numbers = "0123456789";
String lowerChars = "abcdefghijklmnopqrstuvwxyz";
String upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
String specialChar = "!\"#$%&'()*+,‑./:<>=?@";


//We defined the generator object from the Generator class.
var generator = new Generator(); 

var CharacterList = generator.AddList(isNumberStatus, numbers); 
CharacterList = generator.AddList(isLowerCharStatus, lowerChars);
CharacterList = generator.AddList(isUpperCharStatus, upperChars);
CharacterList = generator.AddList(isSpecialCharStatus, specialChar);

Console.WriteLine(generator.RandomPassword(isPasswordLength));






 



//hashmap e bak.ll

//kullanıcıya sorduktan sonra hemen altında isnumberstates y ise number dizini ana dizinin üstğne ekle ve bunu hepsı ıcın yapacaksın, üstüne üstüne ekleyerek yapacaksın, kullanıcının istediği şeylerden oluşan büyük bir dizi olacak ve onun içinden random sayı alacak. 

//randomla sayı ürettiririceksin  0 ile length arasında, ürettirdiğn sayıya karşşılık gelen dizi elemenını al ve bu işlemi dögüye koy .

//pasword için class olabilir, isuppercase bilmem ne de o classın ozellıklerı olur.  password.isuppercase y ise bu diziyi al.

