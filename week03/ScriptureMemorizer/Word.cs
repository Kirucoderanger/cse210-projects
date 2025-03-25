using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Word
{
    public class WordGenerator
    {
        private static List<string> words = new List<string>
        {
            "Matthew 7 24 Therefore whosoever heareth these sayings of mine, and doeth them, I will liken him unto a wise man, which built his house upon a rock",
            "Matthew 7 25 And the rain descended, and the floods came, and the winds blew, and beat upon that house; and it fell not: for it was founded upon a rock",
            "Charity suffereth long, and is kind; charity … Beareth all things, believeth all things, hopeth all things, endureth all things. Charity never faileth.1 Corinthians 13:4, 7–8",
            "There is no fear in love; but perfect love casteth out fear.1 John 4:18",
            "See that ye love one another with a pure heart fervently.1 Peter 1:22",
            "But love ye your enemies, and do good, and lend, hoping for nothing again; and your reward shall be great.Luke 6:35",
            "The stranger that dwelleth with you shall be unto you as one born among you, and thou shalt love him as thyself.Leviticus 19:34",
            "A new commandment I give unto you, That ye love one another; as I have loved you, that ye also love one another. By this shall all men know that ye are my disciples, if ye have love one to another.John 13:34­–35",
            "Are not five sparrows sold for two farthings, and not one of them is forgotten before God? But even the very hairs of your head are all numbered. Fear not therefore: ye are of more value than many sparrows.Luke 12:6–7",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.John 3:16",
            "Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. This is the first and great commandment.Matthew 22:37–38",
            "If ye love me, keep my commandments.John 14:15",
            "1 Nephi 4:6And I was led by the Spirit, not knowing beforehand the things which I should do.",
            "2 Nephi 32:5 For behold, again I say unto you that if ye will enter in by the way, and receive the Holy Ghost, it will show unto you all things what ye should do.",
            "Moroni 10 5 And by the power of the Holy Ghost ye may know the truth of all things.",
            "3 Nephi 28:11And the Holy Ghost beareth record of the Father and me; and the Father giveth the Holy Ghost unto the children of men, because of me.",
            "Moses 1 31 And behold, the glory of the Lord was upon Moses, so that Moses stood in the presence of God, and talked with him face to face. And the Lord God said unto Moses: For mine own purpose have I made these things. Here is wisdom and it remaineth in me.",
            "Doctrine and Covenants 27:15 Wherefore, lift up your hearts and rejoice, and gird up your loins, and take upon you my whole armor, that ye may be able to withstand the evil day, having done all, that ye may be able to stand.",
            "Doctrine and Covenants 42:48 And again, it shall come to pass that he that hath faith in me to be healed, and is not appointed unto death, shall be healed.",
            "Doctrine and Covenants 45:39 And it shall come to pass that he that feareth me shall be looking forth for the great day of the Lord to come, even for the signs of the coming of the Son of Man.",
            "Doctrine and Covenants 64:10 I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men.",
            "Doctrine and Covenants 82:3 For of him unto whom much is given much is required; and he who sins against the greater light shall receive the greater condemnation.",
            "Doctrine and Covenants 82:10 I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.",
            "Doctrine and Covenants 88:15 And the spirit and the body are the soul of man.",
            "Doctrine and Covenants 97:21 Therefore, verily, thus saith the Lord, let Zion rejoice, for this is Zion—the pure in heart; therefore, let Zion rejoice, while all the wicked shall mourn.",
            "Doctrine and Covenants 130:22 The Father has a body of flesh and bones as tangible as man’s; the Son also; but the Holy Ghost has not a body of flesh and bones, but is a personage of Spirit. Were it not so, the Holy Ghost could not dwell in us.",
            "Doctrine and Covenants 137:10 And I also beheld that all children who die before they arrive at the years of accountability are saved in the celestial kingdom of heaven.",
            "Articles of Faith 1 We believe in God, the Eternal Father, and in His Son, Jesus Christ, and in the Holy Ghost.",
            "Articles of Faith 2 We believe that men will be punished for their own sins, and not for Adam’s transgression.",
            "Articles of Faith 3 We believe that through the Atonement of Christ, all mankind may be saved, by obedience to the laws and ordinances of the Gospel.",
            "Articles of Faith 4 We believe that the first principles and ordinances of the Gospel are: first, Faith in the Lord Jesus Christ; second, Repentance; third, baptism by immersion for the remission of sins; fourth, Laying on of hands for the gift of the Holy Ghost.",
            "Articles of Faith 5 We believe that a man must be called of God, by prophecy, and by the laying on of hands by those who are in authority, to preach the Gospel and administer in the ordinances thereof.",
            "Articles of Faith 6 We believe in the same organization that existed in the Primitive Church, namely, apostles, prophets, pastors, teachers, evangelists, and so forth.",
            "Articles of Faith 7 We believe in the gift of tongues, prophecy, revelation, visions, healing, interpretation of tongues, and so forth.",
            "Articles of Faith 8 We believe the Bible to be the word of God as far as it is translated correctly; we also believe the Book of Mormon to be the word of God.",
            "Articles of Faith 9 We believe all that God has revealed, all that He does now reveal, and we believe that He will yet reveal many great and important things pertaining to the Kingdom of God.",
            "Articles of Faith 10 We believe in the literal gathering of Israel and in the restoration of the Ten Tribes; that Zion (the New Jerusalem) will be built upon the American continent; that Christ will reign personally upon the earth; and, that the earth will be renewed and receive its paradisiacal glory.",
            "Articles of Faith 11 We claim the privilege of worshiping Almighty God according to the dictates of our own conscience, and allow all men the same privilege, let them worship how, where, or what they may.",
            "Articles of Faith 12 We believe in being subject to kings, presidents, rulers, and magistrates, in obeying, honoring, and sustaining the law.",
            "Articles of Faith 13 We believe in being honest, true, chaste, benevolent, virtuous, and in doing good to all men; indeed, we may say that we follow the admonition of Paul—We believe all things, we hope all things, we have endured many things, and hope to be able to endure all things. If there is anything virtuous, lovely, or of good report or praiseworthy, we seek after these things."


        };

        public static (string, int) GetRandomWord()
        {
            
            Random random = new Random();
            int index = random.Next(words.Count);
            List<string> splitdWords = words[index].Split(' ').ToList();
            int wordLen = splitdWords.Count;
            int randomWordIndex = random.Next(0,wordLen); 
            string randomScripture = words[index];
            return (randomScripture, randomWordIndex);
            //return string.Join(" ", splitdWords);
            
        }

        static WordSentisaizer sentisaized = new WordSentisaizer();
        public static string sentisaizedWord = sentisaized.GetWord();
        public static List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
        
        
        

        public class WordSentisaizer()
        
        {
            
        
            private string selectedWord = WordGenerator.GetRandomWord().Item1;
             private int selectedIndex = WordGenerator.GetRandomWord().Item2;
             public string GetWord()
             {
                return selectedWord;
             }

             public void setWord(string newWord)
             {
                selectedWord = newWord;

             }
            /*
            public (string, int) GetWordDetails()
            {
                
                List<string> splitdWords = selectedWord.Split(' ').ToList();
                int wordLen = splitdWords.Count;
                Random random = new Random();
                int index = random.Next(words.Count);
                int randomWordIndex = random.Next(0, wordLen);
                return (selectedWord, randomWordIndex);
            }*/

        }

        public class IndexInitializeInts()
        {
            //List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
            private int wordLen = splitdWords.Count;
            private  List<int> Ints = new List<int>();
            public List<int> GetIndexList()
        {
            
            for (int i = 0; i < wordLen ; i++)
                Ints.Add(i);
            return Ints;
        }

        public List<int> RemoveIndex(int newIndex)
             {
                Ints.RemoveAt(newIndex);
                return Ints;
             }


        }

        
        

          
         //public static List<int> ints = new List<int>();

        public static (string, int) GetFullScripture()
        {
             //WordSentisaizer sentisaized = new WordSentisaizer();
             //string sentisaizedWord = sentisaized.GetWord();
             List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
                int wordLen = splitdWords.Count;
                /*for (int i = 0; i < wordLen ; i++)
                    ints.Add(i);*/
             
             return (sentisaizedWord, wordLen);
        }
        
        
        
       
        static IndexInitializeInts initialindex = new IndexInitializeInts();
        public static List<int> ints = initialindex.GetIndexList();
        static List<int> hiddenIndices = new List<int>();
        
        
        
        public static string WordHider()
        {
            
                //WordSentisaizer sentisaized = new WordSentisaizer();
                //string sentisaizedWord = sentisaized.GetWord();
                List<string> splitdWords = sentisaizedWord.Split(' ').ToList();
                

                int wordLen = splitdWords.Count;
                Random random = new Random();
                int indexx = random.Next(ints.Count);
                int randomWordIndex = random.Next(0, wordLen);
                //List<int> hidens = [randomWordIndex];
                //List<int> hiddenIndices = new List<int>();
                //int intigers = 0;
                
                
                //hiddenIndices.RemoveAt(0);

                
                    
                hiddenIndices.Add(ints[indexx]);
                foreach (int hiddenIndex in hiddenIndices)
                {
                char[] letters = splitdWords[hiddenIndex].ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = '_';
                }
                splitdWords[hiddenIndex] = new string(letters);
                }
                ints.Remove(ints[indexx]);
                //initialindex.RemoveIndex(indexx);
                
                
                return string.Join(" ", splitdWords);
                

                //return sentisaizedWord;
        }

        
       









  }


}