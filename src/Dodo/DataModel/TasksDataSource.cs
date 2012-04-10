﻿using System.Collections.ObjectModel;
using Dodo.Logic.Shared;

namespace Dodo.DataModel
{
    public sealed class TasksDataSource
    {
        private ObservableCollection<UserTask> _tasks = new ObservableCollection<UserTask>();
        public ObservableCollection<UserTask> Tasks
        {
            get { return _tasks; }
        }

        private ObservableCollection<Tweet> _tweets = new ObservableCollection<Tweet>();
        public ObservableCollection<Tweet> Tweets
        {
            get { return _tweets; }
        }

        public TasksDataSource()
        {
            var mentions = new UserTask { Title = "New Mentions", Count = 4 };
            var retweets = new UserTask { Title = "New Retweets", Count = 3 };
            var newFollowers = new UserTask { Title = "New Followers", Count = 2 };
            var lostFollowers = new UserTask { Title = "Lost Followers", Count = 1 };

            Tasks.Add(mentions);
            Tasks.Add(retweets);
            Tasks.Add(newFollowers);
            Tasks.Add(lostFollowers);

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });

            Tweets.Add(new Tweet { Author = "_CreativeSouls", Avatar = @"https://si0.twimg.com/profile_images/1934071344/cuteeeee_normal.jpg", Text = "LMAOOOOO RT @spellLONGDICK: deshaun gets no love outchea on these twitter streets LMAO" });
            Tweets.Add(new Tweet { Author = "vickiwilkinson", Avatar = @"https://si0.twimg.com/profile_images/822269892/profile_pic_normal.jpg", Text = "@DPowell217 Thanks to you I have signed into my own Twitter account for the first time in two years. Maybe I'll even keep it up!" });
            Tweets.Add(new Tweet { Author = "dagayamon", Avatar = @"https://si0.twimg.com/profile_images/1214445824/______________normal.jpg", Text = "RT @could0128: Twitter\u306b\u30ce\u30fc\u30d6\u30e9\u306e\u4eba\u3069\u306e\u304f\u3089\u3044\u3044\u308b\u3093\u3060\u308d\u3046\u3002\u30ce\u30fc\u30d6\u30e9\u306e\u4ebaRT\u304a\u9858\u3044\u3057\u307e\u3059\u3002" });
            Tweets.Add(new Tweet { Author = "TrafficDotMy", Avatar = @"https://si0.twimg.com/profile_images/1430490564/kl_thu_03821.93v5xk8lnd44gg4s8o8cggsoo.6z2bh7irr8cgwsss04ogskco8.th_normal.jpeg", Text = "RT @amptraffic: 1815 PLUS: vehicle involved in a much earlier occurred accident at KM 450.2 continues to obstruc... http://t.co/R8cO7OXX" });
            Tweets.Add(new Tweet { Author = "marimoxtuko", Avatar = @"https://si0.twimg.com/profile_images/2031656352\/4296Ma_220_normal.gif", Text = "RT @shamikana: \u5deb\u5973\u30df\u30af\u63cf\u3051\u305f!!\u826f\u3044\u3068\u601d\u3063\u305f\u3089RT\u3057\u3066\u304f\u308c\u305f\u3089\u5b09\u3057\u3044\u3067\u3059(*\u00b4\u2207\uff40*) http://t.co/PPDQdmec" });
            Tweets.Add(new Tweet { Author = "naomimii", Avatar = @"https://si0.twimg.com/profile_images/1976540466/gegchaa_normal.jpg", Text = "@Aiseirrs ternyata di twitter banyak juga yah yang usernamenya pakek nama tokohnya conan lorem ipsum dolor sit amet lorem ipsum dolor sit amet" });
            Tweets.Add(new Tweet { Author = "jugeetta", Avatar = @"https://si0.twimg.com/profile_images/1669017932/image_normal.jpg", Text = "RT @juge_omote: JugeETTA\u6771\u6025\u30d7\u30e9\u30b6\u8868\u53c2\u9053\u539f\u5bbf\u5e97\u3001\u3044\u3044\u611f\u3058\u3067\u3059\u3088\uff01\u5c11\u3057\u516c\u958b\ua4b0 \u2661\u00b4\u2200`\u2661 \ua4b1 http://t.co/29JgD5Sc" });
        }
    }

    
}
