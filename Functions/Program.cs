
string text = "на ту батарею, с которой, по словам штаб-офицера, все поле было видно. Здесь он слез с лошади и остановился у крайнего из четырех снятых с передков орудий. Впереди орудий ходил часовой артиллерист";

string replace(string text, char oldV ,char newV)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldV) result = result + $"{newV}";
        else result = result + $"{text[i]}";
        
    }
    return result;
} 
string NEWTEXT = replace(text,'а','И');
Console.WriteLine(NEWTEXT);
