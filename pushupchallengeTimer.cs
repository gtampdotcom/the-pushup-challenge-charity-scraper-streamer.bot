// https://github.com/gtampdotcom/the-pushup-challenge-charity-scraper-streamer.bot

using System;
using System.IO;
		
public class CPHInline
{
	public bool Execute()
	{
		string total = "0";
		string oldTotal = "0";
		string searchWord = "<h3 class=\"money mt0\"><strong>";
		string searchWordEnd = "</strong>";

		var page = args["page"].ToString();
		var filename = args["filename"].ToString();
		
		if (File.Exists(filename))
        {        
			oldTotal = File.ReadAllText(filename);		
			int start = page.IndexOf(searchWord)+searchWord.Length+1;
			int end = page.IndexOf(searchWordEnd,start);
			total = page.Substring(start,end-start);
		}
		else
		{
			File.WriteAllText(filename, total);
		}
 
		if(Convert.ToDouble(oldTotal) < Convert.ToDouble(total))
		{
			CPH.SendMessage("Total: $" + total);
			File.WriteAllText(filename, total);
		}
		
		return true;
	}
}
