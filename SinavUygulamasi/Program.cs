using System;
/*Sorulan sorulara verilen cevaplarla ilgili true/false bilgisini döndüren
ve doğru cevaba göre puanlayan basit uygulama.*/
namespace SinavUygulamasi
{
    class Question
    {
        public Question(string text,
                        string[] choises,
                        string answer
                        )
        {
            this.Text = text;
            this.Choises = choises;
            this.Answer = answer;
        }
        //Soru
        public string Text { get; set; }

        //Seçenekler 
        public string[] Choises { get; set; }

        //Cevap
        public string Answer { get; set; }


        //cevap kontrol metodu
        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower(); //cevabı küçük harf yaptık.
        }
    }
    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }

        //private tipinde oluşturduğumuz için aşağıda GetQuestion isminde bir  metot oluşturduk(erişim için).
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        // Sorulara erişim sağlamak için oluşturduğumuz metot.
        private Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        //Soruları göstermemizi sağlayan metot.
        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            Console.WriteLine($"soru {this.QuestionIndex + 1}: {question.Text}");

            foreach (var c in question.Choises)
            {
                Console.WriteLine($"-{c}");
            }
            Console.Write("Cevap : ");
            var cevap = Console.ReadLine();
            this.Guess(cevap);

        }

        //Sorunun cevabını kontrol eden metot.
        private void Guess(string answer)
        {
            var question = this.GetQuestion();
            if (question.checkAnswer(answer))
            {
                this.Score++;
            }
            this.QuestionIndex++;

            //Toplam 3 sorumuz mevcut, 3. soruyu aşıp aşmadığımızı kontrol ettiğimiz if yapısı.
            if (this.Questions.Length == this.QuestionIndex)
            {
                this.DisplayScore();
            }
            else
            {
                this.DisplayQuestion();  /*döngü kullanmadan Guess  metodu içinden,
                                         DisplayQuestion metodunu çağırarak işlemimizi gerçekleştirdik.  */
            }

        }
        private void DisplayScore()
        {
            Console.WriteLine($"Score: {this.Score}");
        }

        //Kaçıncı soruda olduğumuzu gösteren metot.
        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex + 1;

            if (totalQuestion >= questionNumber)
            {
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}"); //kaç sorudan kaçıncı sorudayız?
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("En kullanışlı programlama dili nedir?",
                                new string[] { "C#", "Python", "Java", "C++" }, "C#");

            var q2 = new Question("En çok kullanılan programlama dili nedir?",
                                new string[] { "Python", "C#", "Java", "C++" }, "C#");

            var q3 = new Question("En çok iş imkanı olan programlama dili nedir?",
                                new string[] { "C#", "C++", "Java", "Python" }, "C#");

            var questions = new Question[] { q1, q2, q3 };
            var quiz = new Quiz(questions);
            quiz.DisplayQuestion();

        }

    }
}
