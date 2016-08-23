<Query Kind="Program">
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{
	string wordLookupFile = Path.Combine (Path.GetTempPath(), "WordLookup.txt");
	
	if (!File.Exists (wordLookupFile))    // Contains about 150,000 words
		new WebClient().DownloadFile (
			"http://www.albahari.com/ispell/allwords.txt", wordLookupFile);
	//загрузка  словаря английских слов в объект HashSet для обеспечения эффективного поиска
	var wordLookup = new HashSet<string> (
		File.ReadAllLines (wordLookupFile),
		StringComparer.InvariantCultureIgnoreCase);
	
//	использование средства поиска слов для создания текстового "документа", 
//	содержащего массив из 1000000 случайных слов
	var random = new Random();
	string[] wordList = wordLookup.ToArray();
	
	string[] wordsToTest = Enumerable.Range (0, 1000000)
		.Select (i => wordList [random.Next (0, wordList.Length)])
		.ToArray();
	
	wordsToTest [12345] = "woozsh";     // внесение пары 
	wordsToTest [23456] = "wubsie";     // орфографических ошибок
	
    //параллельная проверка орфографии, проверяя wordsToTest на wordLookup
	var query = wordsToTest
		.AsParallel()
		.Select  ((word, index) => new IndexedWord { Word = word, Index = index })
		.Where   (iword => !wordLookup.Contains (iword.Word))
		.OrderBy (iword => iword.Index);
	
	query.Dump();
}

struct IndexedWord { public string Word; public int Index; }