using Antlr4.Runtime;
using myParser;



string input = "1+5*8+6";
Console.WriteLine($"Input {input}\n");

ICharStream stream = CharStreams.fromString(input);
aritmeticaLexer lexer = new aritmeticaLexer(stream);
CommonTokenStream tokens = new CommonTokenStream(lexer);
aritmeticaParser parser = new aritmeticaParser(tokens);
var tree = parser.aritmetica();
aritmetica aritmetica = new aritmetica();

int resultado = aritmetica.Visit(tree);