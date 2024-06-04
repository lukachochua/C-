const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";


// Your work here
// Quantity
string openSpan = "<span>";

int quantityIndex = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");

int openingPos = quantityIndex + openSpan.Length;

int endingPos = quantityEnd - openingPos;

quantity = "Quantity: " + input.Substring(openingPos, endingPos);

//trade symbol

const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);
// h2
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);