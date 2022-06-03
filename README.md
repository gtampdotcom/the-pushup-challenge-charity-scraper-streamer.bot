# the-pushup-challenge-parser for Streamer.bot

C# script for https://streamer.bot that downloads the total donation amount from a https://www.thepushupchallenge.com.au charity page, saves it to a text file and outputs it to Twitch chat.

Copy the big line of text below, run streamer.bot, click on the Actions tab, right click, select import and paste the text into the Import String textbox.

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

If you want it to periodically check the total and post it in chat when it changes, add a Timed Action in streamer bot:

Settings > Timed Actions > pushupchallengeTimer, set the interval to 30 seconds or whatever delay you think is best.

This is unofficial and not endorsed or supported by the pushupchallenge. Use at own risk. They may block too many requests or break compatibility at any time.
