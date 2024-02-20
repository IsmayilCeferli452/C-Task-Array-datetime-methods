



#region Practice


////1) 2 olculu array:

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//Console.WriteLine(numbers[1,1]);

//Console.WriteLine(numbers.Rank);


////2) 3 olculu array:

//int[,,] numbers = { { { 1, 2 }, { 3, 4 }, { 5, 6 } } , { { 7, 8 }, { 9, 10 }, { 10, 11 } } };

//Console.WriteLine(numbers.Rank);

//Console.WriteLine(numbers[1,2,0]);


////3) Contains method:

//int[] numbers = { 1, 2, 3 };

//Console.WriteLine(numbers.Contains(3));



////4) Reverse method:

//string[] words = { "Salam", "Sagol", "Hello", "World" };

//var result = words.Reverse().ToArray();

//Console.WriteLine(result[result.Length - 1]);

//Console.WriteLine(result[0]);


////5) Sort method:

//string[] words = { "Salam", "Sagol", "Hello", "World" };

//Array.Sort(words);

//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}


////6) Reverse etmek:

//int[] numbers = { 3,7,5,9,0,2 };

//Array.Sort(numbers);

//int[] result = numbers.Reverse().ToArray();

//foreach (int number in result)
//{
//    Console.WriteLine(number);
//}


////7) CopyTo method:

//int[] nums1 = { 1, 2, 3 };

//Array.Resize(ref nums1, 7);

//int[] nums2 = { 4, 5, 6, 7 };

//nums2.CopyTo(nums1, 2);

//foreach (int i in nums1)
//{
//    Console.WriteLine(i);
//}


////8) Find method:

//string[] words = { "Salam", "Sagol", "Hello", "World" };

//var result = Array.Find(words, x=> x == "Hello");

//Console.WriteLine(result);


////9) FindAll method:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result = Array.FindAll(words, x => x == "Salam");

//foreach (var word in result)
//{
//    Console.WriteLine(word);    
//}


////10) FindIndex method:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var data = Array.FindIndex(words, x => x == "Salam");

//Console.WriteLine(data);


////11) FindLastIndex method:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result = Array.FindLastIndex(words, x => x == "Salam");

//Console.WriteLine(result);


////12) FirstOrDefault and LastOrDefault methods:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result = words.FirstOrDefault();

//Console.WriteLine(result);

//var response = words.LastOrDefault();

//Console.WriteLine(response);


////13) All method:

//string[] words1 = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result1 = words1.All(x => x == "Salam");

//Console.WriteLine(result1);

//string[] words2 = { "Salam", "Salam" };

//var result2 = words2.All(x => x == "Salam");

//Console.WriteLine(result2);


////14) Any method:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result = words.Any(x => x == "World");

//Console.WriteLine(result);


////15) Exists method:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result = Array.Exists(words, x => x == "Hello");

//Console.WriteLine(result);


////16) Where method:

//string[] words = { "Salam", "Sagol", "Salam", "Sagol", "Hello", "World" };

//var result = words.Where(x => x == "Salam").ToArray();

//foreach (var word in result)
//{
//    Console.WriteLine(word);
//}


////17) OrderBy method:

//string[] words = { "First", "Second", "Third", "Third", "First", "Second" };

//var result = words.OrderBy(x => x);

//foreach (var word in result)
//{
//    Console.WriteLine(word);
//}


////18) OrderByDescending method:

//string[] words = { "First", "Second", "Third", "Third", "First", "Second" };

//var result = words.OrderByDescending(x => x);

//foreach (var word in result)
//{
//    Console.WriteLine(word);
//}





////19) DateTime.Now method:

//DateTime date = DateTime.Now;

//Console.WriteLine(date);


////20) Date Only:

//DateOnly dateOnly = new DateOnly(2000,11,1);

//Console.WriteLine(dateOnly);


////21) DateTime AddYears && Days method:

//DateTime date = DateTime.Now.AddYears(1);

//Console.WriteLine(date);

//DateTime date2 = DateTime.Now.AddDays(2);

//Console.WriteLine(date2);


////22) Birthday yazilmasi:

//DateTime birthday = new DateTime(2000, 11, 1);

//Console.WriteLine(birthday);

//Console.WriteLine(birthday.Year);

//Console.WriteLine(birthday.DayOfWeek);


////23) Format deyismek:

//var date = DateTime.Now;

//Console.WriteLine(date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));


////24) Yasin tapilmasi:

//var currentYear = DateTime.Now.Year;
//var birthday = new DateTime(2000, 1, 1);

//var age = currentYear - birthday.Year;

//Console.WriteLine(age);


#endregion


#region Homework


////Method yazirsiz, Method stringden ibaret array ve char qebul edir.
////Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.


//int CountOfCharInArray( char letter, params string[] words)
//{
//    int count = 0;

//    foreach (string word in words)
//    {
//        foreach(char let in word)
//        {
//            if(let == letter)
//            {
//                count++;
//            }
//        }
//    }
//    return count;

//}

//int result = CountOfCharInArray('A', "AzerbaijAn");

//Console.WriteLine(result);



#endregion