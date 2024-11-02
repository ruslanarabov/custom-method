#region task1
//1.Password yaz.

//     System.Console.WriteLine("Please write the password: ");
//     string password = Console.ReadLine();
//     System.Console.WriteLine(ValidatePassword(password));



// static bool ValidatePassword (string password)
// {   
//     if (password.Length < 8)
//         return false;

//     if (!char.IsUpper(password[0])) 
//         return false;

//     for (int i = 1; i < password.Length; i++)
//     {
//         if (char.IsDigit(password[i]))
//         {
//             for (int j = 1; j < password.Length; j++)
//             {
//                 if (!char.IsLetterOrDigit(password[j]))
//                 {
//                     return true;
//                 }
//             }
//         }
        
//     }return false;
// }   


#endregion


#region task2
//2. methodlari custom yazmag.

//string.replace

// static string CustomReplace (string word, char char1, char char2 )
// {
//     string result = "";

//     for (int i = 0; i < word.Length; i++)
//     {
//         if (word[i] == char1)
//             result += char2; 
//         else
//             result += word[i]; 
//     }

//     return result;
// }

//System.Console.WriteLine(CustomReplace("Code Academy", 'o', 'a'));

//string.substring
// static string CustomSubstring (string word, int firstiIndex, int length)
// {
//     string result = "";
//     for (int i = firstiIndex; i < firstiIndex + length && i < word.Length; i++)
//     {
//         result += word[i];
//     }return result;
// } 

// System.Console.WriteLine(CustomSubstring("Code Academy", 5, 7));

//trim.custom


#endregion
