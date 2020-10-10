using System.IO;

namespace BrainFuckToCSharpCompiler
{
    class BFCompiler
    {
        static readonly string MemoryCells = "class Program {\n" + 
                                             "\tstatic public void Main() {\n" +
                                             "\t\tint[] Mem = new int[30000]; //Memory cells\n" +
                                             "\t\tfor(int i = 0; i < 30000; i++)\n" +
                                             "\t\t\tMem[i] = 0;\n" +
                                             "\t\tint Ptr = 0; //Pointer\n";

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                System.Console.WriteLine("BFCompiler [file_path]");
            }
            else
            {
                string Path = "";
                for(int i = args[0].Length - 1; i >= 0; i--)
                {
                    if (args[0][i] == '\\')
                    {
                        for (int j = 0; j <= i; j++)
                            Path += args[0][j];
                        break;
                    }
                }

                try
                {
                    using StreamReader sr = new StreamReader(args[0]);
                    using StreamWriter sw = new StreamWriter($"{Path}out.cs");
                    sw.WriteLine(MemoryCells); //Вставка ячеек памяти

                    bool IsCycle = false, SyntaxError = false;
                    int Cycles = 0;

                    int Command;
                    while ((Command = sr.Read()) != -1 && !SyntaxError)
                    {
                        string In = "";
                        for (int i = 0; i < Cycles; i++)
                            In += '\t';

                        switch (Command)
                        {
                            case 60: sw.WriteLine(In + "\t\tPtr--;"); break;
                            case 62: sw.WriteLine(In + "\t\tPtr++;"); break;
                            case 43: sw.WriteLine(In + "\t\tMem[Ptr] = (Mem[Ptr] + 1) % 256;"); break;
                            case 45: sw.WriteLine(In + "\t\tMem[Ptr] = (Mem[Ptr] - 1) % 256;"); break;
                            case 91:
                                sw.WriteLine(In + "\t\twhile(Mem[Ptr] > 0) {");
                                IsCycle = true; Cycles++;
                                break;
                            case 93:
                                if (!IsCycle)
                                {
                                    System.Console.WriteLine("Syntax error");
                                    SyntaxError = !SyntaxError;
                                }
                                else
                                {
                                    string EndCycle = "";
                                    for (int i = 0; i < Cycles - 1; i++)
                                        EndCycle += In[i];
                                    sw.WriteLine(EndCycle + "\t\t}");
                                    Cycles--;
                                }
                                break;
                            case 46: sw.WriteLine(In + "\t\tSystem.Console.Write((char)Mem[Ptr]);"); break;
                            case 44: sw.WriteLine(In + "\t\tMem[Ptr] = System.Console.Read();"); break;
                            default: break;
                        }
                    }
                    sw.WriteLine("\t}\n}");
                }
                catch
                {
                    System.Console.WriteLine("Invalid file path");
                }
            }
        }
    }
}
