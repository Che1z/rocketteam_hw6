namespace rocketTeamhw6;

class Program
{
    static void Main(string[] args)
    {
        //// 取得日期的不同部分
        //DateTime now = DateTime.Now;
        //int year = now.Year;
        //int month = now.Month;
        //int day = now.Day;
        //int hour = now.Hour;
        //int minute = now.Minute;
        //int second = now.Second;
        //Console.WriteLine($"現在的時間{now}");
        //Console.WriteLine(now.ToString("yyyy MMMM")); 
        //Console.WriteLine($"{year}年, {month}月, {day}天, {hour}時, {minute}分, {second}秒");


        ////未來三個月、前兩天
        //DateTime now = DateTime.Now;
        //DateTime future = now.AddMonths(3);
        //DateTime pastTwoDay = now.AddDays(-2);
        //Console.WriteLine($"未來三個月{future}");
        //Console.WriteLine($"過去兩天{pastTwoDay}");


        //今天禮拜幾
        //DateTime now = DateTime.Now;
        //DayOfWeek dayOfWeek = now.DayOfWeek;
        //Console.WriteLine("今天是" +now.ToString("dddd"));

        //Console.WriteLine($"今天是{dayOfWeek}");

        ////距離過年有多少天
        //DateTime now = DateTime.Now;
        //DateTime targetDay = new DateTime(now.Year, 2, 9);
        //int newYear = (int)(targetDay - now).TotalDays;
        //Console.WriteLine($"今天是{now:yyyy年MM月dd日},距離過年還有{newYear}天");

        // 從49個亂數中生成1個
        //Random random = new Random();
        //int randomNumber = random.Next(1, 50);
        //Console.WriteLine(randomNumber);

        //今天的幸運日是哪一天
        //DateTime nowday = DateTime.Now;
        //Random random = new Random();
        //int randomday = random.Next(1, 366);
        //DateTime randomluckyday = nowday.AddDays(randomday);
        //Console.WriteLine(randomluckyday);

        //string pattern = @"^[A-Z]\d{9}$";
        //Regex ReObj = new Regex(pattern);
        //Console.WriteLine("請使用者輸入");
        //string input = Console.ReadLine();
        //Console.WriteLine(ReObj.IsMatch(input));
        //Console.ReadKey();

        // <--- 功課開始 --->

        // Q:輸入姓名，輸出Hi~輸入的姓名，輸入Justin，輸出Hi~Justin。

        //Console.WriteLine("請輸入姓名");
        //string userInput = Console.ReadLine();
        //Console.WriteLine($"Hi~ {userInput}");


        // Q:請輸入任何一個字，是否出現在
        // ”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。

        //string stringContent  = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
        //Console.WriteLine("請輸入檢查字");

        //string userCheck = Console.ReadLine();
        //if (stringContent.Contains(userCheck))
        //{
        //    Console.WriteLine("有出現！");
        //}
        //else {
        //    Console.WriteLine("並沒有出現過！");
        //}

        // Q:輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e
        // Note:Insert是就既有內容再增加內容，需注意for loop新增數字需更多1，否則就一直增加下去

        //Console.WriteLine("請輸入文字");
        //string input = Console.ReadLine();

        //for (int i = 1; i < input.Length; i += 2)
        //{
        //    input = input.Insert(i, "-");
        //}
        //Console.WriteLine(input);

        ////Q:輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg
        //Console.WriteLine("請輸入檔名");
        //string fileName = Console.ReadLine();
        //int dotPosition = fileName.IndexOf(".");
        //Console.WriteLine(fileName.Substring(dotPosition + 1));


        // Q: 輸入一個大於五個字的單字，若小於五個字輸出長度不夠，
        // 若大於五個字，則輸出前三個字。Length  Substring()

        //Console.WriteLine("請輸入單字");
        //string userInput = Console.ReadLine();
        //if (userInput.Length < 5)
        //{
        //    Console.WriteLine("長度不夠");
        //}
        //else
        //{
        //    Console.WriteLine(userInput.Substring(0, 3));
        //}

        // Q:輸入一段字，輸出把輸入的一段字裡面的我，
        // 改成小明，如輸入我在唱歌，輸出小明在唱歌。

        //string userInput = Console.ReadLine();
        //Console.WriteLine(userInput.Replace("我","小明"));

        ////Q:輸入一串字，顯示輸入幾個字
        //Console.WriteLine("請輸入字串");
        //string userInput = Console.ReadLine();
        //Console.WriteLine($"已輸入{userInput.Length}個字");

        //// Q:連續輸入10組字，若沒輸入過，就顯示沒出現過，
        //若輸入過，就顯示輸入過

        //string[] tenString = new string[10];
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"請輸入第{i+1}項文字");
        //    string userInput = Console.ReadLine();

        //    if (tenString.Contains(userInput))
        //    {
        //        Console.WriteLine("輸入過");
        //    }
        //    else {
        //        Console.WriteLine("沒出現過");
        //    }
        //    tenString[i] = userInput;
        //}

        // 用IndexOf解

        //string[] userInput = new string[10];

        //for (int i = 0; i < userInput.Length; i++)
        //{
        //    Console.WriteLine($"目前輸入第：{i + 1}項");
        //    userInput[i] = Console.ReadLine();

        //    if (Array.IndexOf(userInput, userInput[i], 0, i) != -1)
        //    {
        //        Console.WriteLine("已輸入過");
        //    }
        //    else
        //    {
        //        Console.WriteLine("沒出現過");
        //    }
        //}

        //Q:用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出
        //  Fifa
        //  fIfa
        //  fiFa
        //  fifA

        //法一：
        //Console.WriteLine("請輸入字母");
        //string userInput = Console.ReadLine();

        //for (int i = 0; i < userInput.Length; i++)
        //{
        //    userInput = userInput.ToLower();
        //    char[] inputChar = userInput.ToCharArray();
        //    inputChar[i] = Convert.ToChar(inputChar[i].ToString().ToUpper());
        //    Console.WriteLine(inputChar);
        //}


        //法二:

        //// 次數
        //for (int i = 0; i < userInput.Length; i++)
        //{
        //    // 裡頭的字去做更改
        //    for (int j = 0; j < userInput.Length; j++)
        //    {
        //        char currentChar = userInput[j];
        //        char modifiedChar = (i == j) ? Char.ToUpper(currentChar) : Char.ToLower(currentChar);
        //        Console.Write(modifiedChar);
        //    }
        //    Console.WriteLine("");
        //}

        ////法三:

        /// 使用：StringBuilder需使用System.Text
        //Console.WriteLine("請輸入字母");
        //string userInput = Console.ReadLine();
        //StringBuilder result = new StringBuilder();

        //for (int i = 0; i < userInput.Length; i++)
        //{


        //    for (int j = 0; j < userInput.Length; j++)
        //    {
        //        char curChar = userInput[j];
        //        char transChar = (i == j ? Char.ToUpper(curChar) : Char.ToLower(curChar));
        //        result.Append(transChar);

        //    }
        //    result.AppendLine();
        //}
        //Console.WriteLine(result);






        //Q:輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。

        //Console.WriteLine("請輸入時間");
        //string userInput = Console.ReadLine();
        //if (DateTime.TryParse(userInput, out DateTime time))
        //{
        //    string result = time.ToString("HH點mm分");
        //    Console.WriteLine(result);
        //}
        //else {
        //    Console.WriteLine("輸入格式異常");
        //}



        // Q:輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
        //< ul >
        //    < li > Justin<li>
        //    < li > Amy<li>
        //    < li > David<li>
        //</ ul >

        //Console.WriteLine("請輸入名字");
        //string userInput = Console.ReadLine();
        //string[] userInputArray = userInput.Split(",");
        //List<string> result = new List<string> { "<ul>" };

        //foreach (string ele in userInputArray)
        //{
        //    result.Add(string.Format("  <li>{0}</li>", ele));
        //}
        //string filePath = @"/Users/shihminhung/Desktop/text.test.html";
        //result.Add("</ul>");
        //File.WriteAllLines(filePath, result);


        ////Q:輸入5處數字，用空白隔開，輸出結果。
        ////例如：輸入‘11 19 12 25 1 7 12，輸出總和是87

        //Console.WriteLine("請輸入數字");
        //string input = Console.ReadLine();

        //string[] inputArray = input.Split(" ");
        //int result = 0;
        //foreach (string ele in inputArray)
        //{
        //    result += Convert.ToInt32(ele);
        //}
        //Console.WriteLine($"總和是{result}");


        //// Q:寫一篇中文歌的歌詞到自己指定的文字檔(使用UTF-8編碼)。
        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //string createString = "畫面裡不需要旁白 卻誰都看得出來";
        //File.WriteAllText(filePath, createString);

        //// Q:讀取1.txt 顯示在畫面上。
        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //string input = File.ReadAllText(filePath);
        //Console.WriteLine(input);
        //Process.Start(filePath);

        //Q:寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //for (int i = 1; i < 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        string input = $"{i} * {j} = {i * j}" + Environment.NewLine;
        //        File.AppendAllText(filePath, input);
        //    }
        //}

        //Q:讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，
        //轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)

        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //Process.Start(filePath);

        //////讀取
        //string text = File.ReadAllText(filePath);
        //Console.WriteLine("轉換後:");
        //char[] charArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //char[] replaceArray = new char[] { '零', '壹', '貳', '參', '肆', '伍', '陸', '柒', '捌', '玖' };
        //string newString = text;
        //for (int i = 0; i < charArray.Length; i++)
        //{
        //    newString = newString.Replace(charArray[i], replaceArray[i]);
        //}
        //Console.WriteLine(newString);
        //File.WriteAllText(filePath, newString);





        ////Q: 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲
        ////存到指定的HTML檔裡
        //string filePath = @"/Users/shihminhung/Desktop/fc4bb.csv";
        //string[] rowString = File.ReadAllLines(filePath);

        ////儲存在List內(IEnumerable變數)
        //List<string> rowData = new List<string>(rowString);

        //for (int i = 0; i < rowData.Count; i++)
        //{
        //    string eachLine = rowData[i].Replace(",", "</td>\n<td>");

        //    //第一行
        //    if (i == 0)
        //    {
        //        rowData[0] = rowData[0].Replace(",", "</td>\n<td>");
        //        rowData[0] = $"<table>\n<thead>\n<td>{rowData[0]}</td>\n</thead>";

        //    }
        //    //最後行
        //    else if (i == rowData.Count-1) {
        //        rowData[i] = $"<td>{eachLine}</td>\n</table>";
        //    }
        //    //中間行
        //    else
        //    {
        //        rowData[i] = $"<tr>\n<td>{eachLine}</td>\n</tr>";
        //    }
        //}


        //string resultPath = @"/Users/shihminhung/Desktop/result.html";
        //File.WriteAllLines(resultPath, rowData);

        //string first = rowData[0];
        //first = first.Replace(",", "</td>\n<td>");
        //first = $"<tr>\n<td>{first}</td>\n</tr>";
        //Console.WriteLine(first);


        //string filePath = @"/Users/shihminhung/Desktop/testfile.csv";

        //List<string> stringResult = new List<string> { "<table>" };
        //List<string> stringTest = new List<string>(File.ReadAllLines(filePath));
        //for (int i = 0; i < stringTest.Count; i++)
        //{
        //    if (i == 0)
        //    {
        //        string[] stringZero = stringTest[0].Split(",");
        //        stringResult[0] += "\n" + string.Format(" <thead> \n  <tr> \n   <td>{0}</td>\n   <td>{1}</td> \n  <td>{2}</td> \n <td>{3}</td> \n    </tr> \n </thead>", stringZero[0], stringZero[1], stringZero[2], stringZero[3]);
        //    }
        //    else if (i == 1)
        //    {
        //        string[] stringOne = stringTest[1].Split(",");


        //        stringResult.Add(string.Format("<tbody> \n <tr> \n <td>{0}</td>\n <td>{1}</td>\n <td>{2}</td> \n <td>{3}</td>\n </tr>", stringOne[0], stringOne[1], stringOne[2], stringOne[3]));
        //    }
        //    else
        //    {
        //        string[] stringElse = stringTest[i].Split(",");
        //        stringResult.Add(string.Format("<tr> \n <td>{0}</td> \n  <td>{1}</td> \n <td>{2}</td> \n <td>{3}</td> \n </tr>", stringElse[0], stringElse[1], stringElse[2], stringElse[3]));
        //    }
        //}
        //stringResult.Add("</tbody>" + " \n " + "</table>");
        //string restorePath = @"/Users/shihminhung/Desktop/test100.html";
        //foreach (string ele in stringResult)
        //{
        //    File.AppendAllText(restorePath, ele);
        //}


        //// Q:請隨機由0~99產生一個數字輸出。
        //Random randomNumber = new Random();
        //Console.WriteLine(randomNumber.Next(0, 100));

        //// Q:請隨機由0~99產生10個數字輸出。

        //int[] tenArray = new int[10];
        //Random randomNumber = new Random();

        //for (int i = 0; i < 10; i++)
        //{
        //    tenArray[i] = randomNumber.Next(0, 100);
        //}
        //foreach (int ele in tenArray)
        //{
        //    Console.WriteLine(ele);
        //}




        ////Q: 隨機幫每位學員產生成績，並寫入文字檔
        ////(欄位之間用，分開，換行寫入下一筆)。

        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //Random random = new Random();
        ////假設幫10位學員產生隨機成績
        //for (int i = 0; i < 10; i++)
        //{
        //    int randomGrade = random.Next(0, 101);
        //    string newGrade = $"第{i}位學生：" + randomGrade + "," + Environment.NewLine;
        //    File.AppendAllText(filePath, newGrade);
        //}



        // Q: 請設計樂透開獎程式。

        // 01~49選6個數字進行投注 （需注意不能重複）
        //Random random = new Random();
        //int[] lotteryNumber = new int[6];
        //for (int i = 0; i < 6; i++)
        //{
        //    int randomNumber;
        //    do {
        //        randomNumber = random.Next(1, 50);
        //    }
        //    while (lotteryNumber.Contains(randomNumber));
        //    lotteryNumber[i] = randomNumber;
        //}
        //foreach (int ele in lotteryNumber)
        //{
        //    Console.WriteLine(ele);
        //}



        //Q: 文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出
        //    // 今天中午要吃哪一家

        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //string fileText = File.ReadAllText(filePath);
        //string[] formatString = fileText.Split("\n");

        //Random random = new Random();
        //int randomNumber = random.Next(0, formatString.Length);
        //Console.WriteLine($"今天中午吃：{formatString[randomNumber].Substring(2)}");


        //// Q: 文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出
        //// 今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽

        //string filePath = @"/Users/shihminhung/Desktop/text.test.txt";
        //string fileText = File.ReadAllText(filePath);
        ////人員資料array
        //string[] textArray = fileText.Split("\n");

        ////建立List
        //List<string> dataList = new List<string>(textArray);

        //// 紀錄哪幾位已經被抽中 (不重複)
        //// 建立抽取順序array
        //List<int> randomNumberList = new List<int> { };
        //for (int i = 0; i < dataList.Count; i++)
        //{
        //    // List要用Add method
        //    randomNumberList.Add(i);
        //}

        ////檢查隨機數字，是否已經存在於randomNumberList中
        //Random random = new Random();
        //int randomNumber;
        //while (randomNumberList.Count > 0) {
        //    randomNumber = random.Next(0, textArray.Length);
        //    if (randomNumberList.Contains(randomNumber))
        //    {
        //        Console.WriteLine($"今天的值日生為{dataList[randomNumber]}");
        //        randomNumberList.Remove(randomNumber);

        //    }    
        //}

        //// ------日期------
        ////Q: 顯示現在日期與時間
        //Console.WriteLine(DateTime.Now);

        ////Q: 顯示再過30天為哪一天
        //DateTime now = DateTime.Now;
        //Console.WriteLine( now.AddDays(30));

        ////Q: 顯示24小時前的年月日時分秒
        //DateTime now = DateTime.Now;
        //DateTime before24hours = now.AddHours(-24);
        //string result = before24hours.ToString("yyyy/MM/dd HH:mm:ss");
        //Console.WriteLine(result);

        //Q: 取得目前是幾月
        //DateTime now = DateTime.Now;
        //Console.WriteLine($"現在是{now.Month}月");


        //Q: 取得明年是否為閏年。(可以試試民國)
        //DateTime now = DateTime.Now;
        //int year = now.AddYears(1).Year;
        //if (!DateTime.IsLeapYear(year))
        //{
        //    Console.WriteLine($"明年:{year}不是閏年");
        //}
        //else {
        //    Console.WriteLine($"明年:{year}是閏年");
        //}


        ////Q: 取得離2024年1月1日還有幾天
        //DateTime targetDay = new DateTime(2024, 01, 01);
        //DateTime now = DateTime.Now;
        //Console.WriteLine($"還有{(targetDay-now).Days}天");

        //// Note: TotalDays(整數含小數位的天數)、Days(整數位天數)


        //Q:星期一，猴子穿新衣，
        //星期二，猴子肚子餓，
        //星期三，猴子去爬山，
        //星期四，猴子看電視，
        //呈期五，猴子去跳舞，
        //星期六，猴子去斗六，
        //星期日，猴子過生日。
        //請顯示今天猴子做甚麼事。

        //DateTime now = DateTime.Now;
        //switch (now.DayOfWeek)
        //{
        //    case DayOfWeek.Monday:
        //        Console.WriteLine("星期一，猴子穿新衣");
        //        break;
        //    case DayOfWeek.Tuesday:
        //        Console.WriteLine("星期二，猴子肚子餓");
        //        break;
        //    case DayOfWeek.Wednesday:
        //        Console.WriteLine("星期三，猴子去爬山");
        //        break;
        //    case DayOfWeek.Thursday:
        //        Console.WriteLine("星期四，猴子看電視");
        //        break;
        //    case DayOfWeek.Friday:
        //        Console.WriteLine("星期五，猴子去跳舞");
        //        break;
        //    case DayOfWeek.Saturday:
        //        Console.WriteLine("星期六，猴子去斗六");
        //        break;
        //    case DayOfWeek.Sunday:
        //        Console.WriteLine("星期日，猴子過生日。");
        //        break;
        //}

        //// Q:輸入‘兩個日期，輸出兩個日期相差幾天

        //Console.WriteLine("請輸入第一個日期");
        //string input1 = Console.ReadLine();
        //DateTime day1 = new DateTime();
        //if (DateTime.TryParse(input1, out DateTime result))
        //{
        //    day1 = result;
        //}
        //while (!DateTime.TryParse(input1, out DateTime time1))
        //{
        //    Console.WriteLine("輸入錯誤，請再輸入第一個日期");
        //    input1 = Console.ReadLine();
        //};
        //// 第二個日期
        //Console.WriteLine("請輸入第二個日期");
        //string input2 = Console.ReadLine();
        //DateTime day2 = new DateTime();
        //if (DateTime.TryParse(input2, out DateTime result2))
        //{
        //    day2 = result2;
        //}
        //while (!DateTime.TryParse(input2, out DateTime time2))
        //{
        //    Console.WriteLine("輸入錯誤，請再輸入第一個日期");
        //    input2 = Console.ReadLine();
        //};
        //Console.WriteLine($"兩者差{Math.Abs((day2 - day1).Days)}天");

        ////Q: 兩光法師占卜，隨機產生一個今年日期，再使用公式：S=(M*2+D)%3，
        ////S 的值從 0 到 2分別給與 普通、吉、大吉三種不同的運勢，輸出運勢
        //Random random = new Random();
        //DateTime begin = new DateTime(2024, 01, 01);
        //DateTime randomDay = begin.AddDays(random.Next(0, 366));
        //Console.WriteLine($"隨機日是：{randomDay}");
        //int month = randomDay.Month;
        //int day = randomDay.Day;
        //int s = (month * 2 + day) % 3;
        //if (s == 0)
        //{
        //    Console.WriteLine("運勢：普通");
        //}
        //else if (s == 1)
        //{
        //    Console.WriteLine("運勢：吉");
        //}
        //else {
        //    Console.WriteLine("運勢：大吉");
        //}

        //Function Q2: 回傳輸入的值是否數字
        //numberCheck();


        //// Function Q3: 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        //emailValidation();

        // Function Q4: 寫一個function，回傳輸入的值是否符合手機格式
        //phonenumberValidation();

        //// Function Q5: 寫一個function，回傳輸入的值是否符合身分證字號格式
        //idValidation();


        // Function Q6: 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
        //dotProcess(2);

        //Function Q7:輸入一個日期，把該日期轉成民國年.月.日格式
        //convertToROC();

        //Function Q8:寫一個function，輸入一個日期，
        //把該日期轉成民國XX年XX月XX日 星期X 格式
        //convertToROC();

        //Function Q9:寫一個function，回傳輸入的年是否閏年
        //isLeapYear();

        //Function Q10:寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：
        //用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），
        //再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果
        //luckyPhoneNumber();
    }

    //Function

    //// Q: 1. 寫一個function 可以把一般對話框的文字轉成HTML。> 轉成 &gt;
    //// < 轉成 &lt; \r\n 轉成 <br> | 轉成 &brvbar; 空白 轉成 &nbsp
    //static string convertToHtml(string input)
    //{
    //    string result = input.Replace(">", "&gt;").Replace("<", "&lt;").Replace("\r\n", "<br>").Replace("|", "&brvbar;").Replace(" ", "&nbsp;");

    //    return result;
    //}


    // Q:2. 寫一個function，回傳輸入的值是否數字

    //static void numberCheck() {
    //    Console.WriteLine("請輸入檢查值");
    //    string userInput = Console.ReadLine();
    //    if (double.TryParse(userInput, out double number))
    //    {
    //        Console.WriteLine($"輸入值為數字：{number}");
    //    }
    //    else {
    //        Console.WriteLine($"輸入值為非數字:{userInput}");
    //    }
    //}

    //// Q: 3. 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式

    //// 規則 userName@domainName.com(.tw||.br ...)

    //static void emailValidation() {
    //    Console.WriteLine("請輸入欲檢查的Email");
    //    string userInput = Console.ReadLine();
    //    string checkPattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+(\.com|\.com\.[a-z]{2}$)";
    //    Regex ReObj = new Regex(checkPattern);
    //    bool checkResult = ReObj.IsMatch(userInput);
    //    Console.WriteLine($"檢查結果為:{checkResult}");
    //}
    ////


    ////Q:4. 寫一個function，回傳輸入的值是否符合手機格式

    ////格式： 09開頭、總共為8碼數字
    //static void phonenumberValidation() {
    //    Console.WriteLine("請輸入欲檢查的手機號碼");
    //    string checkPattern = @"^09[0-9]{6}$";
    //    string userInput = Console.ReadLine();
    //    if (int.TryParse(userInput, out int phoneNumber))
    //    {
    //        Regex ReObj = new Regex(checkPattern);
    //        bool checkResult = ReObj.IsMatch(userInput);
    //        if (checkResult)
    //        {
    //            Console.WriteLine($"確實為手機號碼：{phoneNumber}");
    //        }
    //        else {
    //            Console.WriteLine("輸入值不符合手機號碼格式");
    //        }
    //    }
    //    else {
    //        Console.WriteLine("錯誤，請輸入純數字");
    //    }

    //}

    ////Q:5 寫一個function，回傳輸入的值是否符合身分證字號格式

    ////規則： 總共10碼，A-Z開頭、1|2、0-9(8碼)
    //static void idValidation() {
    //    Console.WriteLine("請輸入欲檢查的身分證");
    //    string userInput = Console.ReadLine();
    //    string checkPattern = @"[A-Z][12][0-9]{8}$";
    //    Regex regexObject = new Regex(checkPattern);
    //    bool checkResult = regexObject.IsMatch(userInput);
    //    if (checkResult)
    //    {
    //        Console.WriteLine("檢查結果符合身分證格式");
    //    }
    //    else {
    //        Console.WriteLine("不符合身分證格式");
    //    }
    //}

    ////Q:6  寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
    //static void dotProcess(int maxLength) {
    //    Console.WriteLine("請輸入文字");
    //    string userInput = Console.ReadLine();

    //    if (userInput.Length > maxLength)
    //    {
    //        string convertResult = userInput.Substring(0, maxLength) + "...";
    //        Console.WriteLine(convertResult);
    //    }
    //    else {
    //        Console.WriteLine(userInput);
    //    }

    //}

    ////Q: 7 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
    //static void convertToROC() {
    //    Console.WriteLine("請輸入日期");
    //    string userInput = Console.ReadLine();
    //    if (DateTime.TryParse(userInput, out DateTime inputTime))
    //    {
    //        string result = $"民國{inputTime.Year - 1911}年{inputTime.Month}月{inputTime.Day}日";
    //        Console.WriteLine(result);
    //    }
    //    else {
    //        Console.WriteLine("輸入格式錯誤");
    //    }
    //}

    //Q: 8 寫一個function，輸入一個日期，
    //把把該日期轉成民國XX年XX月XX日 星期X 格式
    //static void convertToROC() {
    //    Console.WriteLine("請輸入日期");
    //    string userInput = Console.ReadLine();
    //    if (DateTime.TryParse(userInput, out DateTime time)) {      
    //        string formatted = time.AddYears(-1911).ToString("民國yyy年MM月dd日 ") + convertToChineseDay(time.DayOfWeek);
    //        Console.WriteLine(formatted);
    //    }
    //}

    // 在C# switch case語句中，當使用enum時，需傳入完整的enum值：DayOfWeek.Sunday
    //static string convertToChineseDay(DayOfWeek dayofweek) {
    //    switch (dayofweek) {
    //        case DayOfWeek.Monday:
    //            return "星期一";
    //        case DayOfWeek.Tuesday:
    //            return "星期二";
    //        case DayOfWeek.Wednesday:
    //            return "星期三";
    //        case DayOfWeek.Thursday:
    //            return "星期四";
    //        case DayOfWeek.Friday:
    //            return "星期五";
    //        case DayOfWeek.Saturday:
    //            return "星期六";
    //        case DayOfWeek.Sunday:
    //            return "星期日";
    //        default:
    //            return "";
    //    }

    //}

    //Q: 9 寫一個function，回傳輸入的年是否閏年
    //static void isLeapYear() {
    //    Console.WriteLine("請輸入檢查年份");
    //    int inputYear = Convert.ToInt32(Console.ReadLine());
    //    if (DateTime.IsLeapYear(inputYear)) {
    //        Console.WriteLine("是閏年");
    //    }
    //    else {
    //        Console.WriteLine("不是閏年");
    //    }
    //}

    ////Q: 10 寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：
    ////用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），
    ////再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果
    //static void luckyPhoneNumber()
    //{
    //    Console.WriteLine("請輸入手機號碼");
    //    string userInput = Console.ReadLine();
    //    bool userPhoneNumber = int.TryParse(userInput, out _);
    //    if (userPhoneNumber)
    //    {
    //        double lastFour = Convert.ToDouble(userInput.Substring(userInput.Length - 4));
    //        lastFour /= 80;
    //        int dotPosition = lastFour.ToString().IndexOf(".");
    //        double finalLastFour = Convert.ToDouble("0" + lastFour.ToString().Substring(dotPosition));
    //        Console.WriteLine($"最終幸運數字為：{finalLastFour * 80}");
    //    }
    //    else
    //    {
    //        Console.WriteLine("輸入錯誤");
    //    }

    //}
}

