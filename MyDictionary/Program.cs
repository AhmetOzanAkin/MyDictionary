using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> dictionary;

    public MyDictionary()
    {
        dictionary = new Dictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        if (dictionary.ContainsKey(key))
        {
            Console.WriteLine($"Anahtar '{key}' zaten var. Değer '{value}' eklenemedi.");
        }
        else
        {
            dictionary.Add(key, value);
            Console.WriteLine($"Anahtar '{key}' ve değer '{value}' başarıyla eklendi.");
        }
    }
}

class Program
{
    static void Main()
    {
        MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
        dictionary.Add("apple", 10);
        dictionary.Add("banana", 20);
        dictionary.Add("cherry", 30);
    }
}
