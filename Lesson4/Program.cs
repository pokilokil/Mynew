static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:\a"); 
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a "; 
    Console.WriteLine(strWithTabs); 
    Console.WriteLine("Everyone loves V'Hello World\"\a "); 
    Console.WriteLine("C:\\MyApp\\bin\\Debug\a "); 
    // Добавить четыре пустых строки и снова выдать звуковой сигнал.
    Console.WriteLine("All finished.\n\n\n\a ");
    Console.WriteLine();
      

}