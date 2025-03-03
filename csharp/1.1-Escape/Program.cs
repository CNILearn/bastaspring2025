// VT100 escape characters

Console.Beep();

Console.WriteLine("\e[2J"); // Clear the screen
Console.WriteLine("\e[5;5H"); // Move cursor to row 5, column 5
Console.WriteLine(@"  _______ ");
Console.WriteLine(@" /       \ ");
Console.WriteLine(@"|  O   O  |");
Console.WriteLine(@"|    ^    |");
Console.WriteLine(@"|  \___/  |");
Console.WriteLine(@" \_______/ ");
Console.WriteLine();
Console.WriteLine("\e[5mHello BASTA! Frankfurt 2025!\e[0m");
Console.WriteLine();

//Console.WriteLine("This is a regular text");
//Console.WriteLine("\u001b[1mThis is a bold text\u001b[0m");
//Console.WriteLine("\u001b[2mThis is a dimmed text\u001b[0m");
//Console.WriteLine("\u001b[3mThis is an italic text\u001b[0m");
//Console.WriteLine("\u001b[4mThis is an underlined text\u001b[0m");
//Console.WriteLine("\u001b[5mThis is a blinking text\u001b[0m");
//Console.WriteLine("\u001b[6mThis is a fast blinking text\u001b[0m");
//Console.WriteLine("\u001b[7mThis is an inverted text\u001b[0m");
//Console.WriteLine("\u001b[8mThis is a hidden text\u001b[0m");
//Console.WriteLine("\u001b[9mThis is a crossed-out text\u001b[0m");
//Console.WriteLine("\u001b[21mThis is a double-underlined text\u001b[0m");
//Console.WriteLine("\u001b[38;2;255;0;0mThis is a red text\u001b[0m");
//Console.WriteLine("\u001b[48;2;0;255;0mThis is a green background\u001b[0m");
//Console.WriteLine("\u001b[38;2;0;0;255;48;2;255;255;0mThis is a blue text with a yellow background\u001b[0m");

Console.WriteLine("This is a regular text");
Console.WriteLine("\e[1mThis is a bold text\e[0m");
Console.WriteLine("\e[2mThis is a dimmed text\e[0m");
Console.WriteLine("\e[3mThis is an italic text\e[0m");
Console.WriteLine("\e[4mThis is an underlined text\e[0m");
Console.WriteLine("\e[5mThis is a blinking text\e[0m");
Console.WriteLine("\e[6mThis is a fast blinking text\e[0m");
Console.WriteLine("\e[7mThis is an inverted text\e[0m");
Console.WriteLine("\e[8mThis is a hidden text\e[0m");
Console.WriteLine("\e[9mThis is a crossed-out text\e[0m");
Console.WriteLine("\e[21mThis is a double-underlined text\e[0m");
Console.WriteLine("\e[38;2;255;0;0mThis is a red text\e[0m");
Console.WriteLine("\e[48;2;0;255;0mThis is a green background\e[0m");
Console.WriteLine("\e[38;2;0;0;255;48;2;255;255;0mThis is a blue text with a yellow background\e[0m");
