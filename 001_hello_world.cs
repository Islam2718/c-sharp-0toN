using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // foreach (var arg in args)
            // {
            //     Console.WriteLine($"Argument: {arg}");
            // }
        }
    }
}

// static void Main(string[] args)-এর ভেতরে থাকা string[] args মূলত কমান্ড-লাইন আর্গুমেন্ট 
// (Command-Line Arguments) গ্রহণ করার জন্য ব্যবহার করা হয়। এটি প্রোগ্রাম রান করার সময় টার্মিনাল 
// বা কমান্ড প্রম্পট থেকে বাইরে থেকে কোনো ডেটা বা ইনপুট প্রোগ্রামের ভেতরে পাঠানোর একটি মাধ্যম।
// dotnet run Abdur Rahman