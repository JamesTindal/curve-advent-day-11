﻿var gifts = new List<string>{
    "Twelve drummers drumming",
    "Eleven pipers piping",
    "Ten lords a-leaping",
    "Nine ladies dancing",
    "Eight maids a-milking",
    "Seven swans a-swimming",
    "Six geese a-laying",
    "Five golden rings",
    "Four calling birds",
    "Three french hens",
    "Two turtle doves and",
    "A partridge in a pear tree.",
};

for (int i = gifts.Count - 1; i >= 0; i--)
{
    Console.WriteLine("On the first day of Christmas\nMy true love gave to me:");
    for (int j = i; j < gifts.Count; j++)
    {
        Console.WriteLine(gifts[j]);
    }
    Console.WriteLine("");
}