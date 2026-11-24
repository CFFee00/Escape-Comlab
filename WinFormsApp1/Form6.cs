
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        private Form1 mainMenu;
        private SoundPlayer music;

        private int currentQuestion = 0;
        private int remainingTime = 600;
        private int penaltySeconds = 30;
        private int hintsRemaining = 3;

        private bool isPaused = false;
        private bool gameEnded = false;

        private Random random = new Random();

        private List<Question> allQuestions = new List<Question>();
        private List<Question> questions = new List<Question>();
        private List<Question> reserveQuestions = new List<Question>();

        private class Question
        {
            public string Text;
            public string[] Choices;
            public int CorrectAnswer;
            public string Hint;

            public Question(string text, string a, string b,
                string c, string d, int answer, string hint)
            {
                Text = text;
                Choices = new string[] { a, b, c, d };
                CorrectAnswer = answer;
                Hint = hint;
            }
        }

        public Form6(Form1 menu, string difficulty)
        {
            InitializeComponent();

            mainMenu = menu;

            string musicPath = Path.Combine(
                Application.StartupPath,
                "Sounds",
                "background.wav"
            );

            try
            {
                if (File.Exists(musicPath))
                {
                    music = new SoundPlayer(musicPath);
                    music.PlayLooping();
                }
            }
            catch
            {
                music = null;
            }

            lblDifficulty.Text = "Difficulty: " + difficulty;

            SetQuestions(difficulty);


            hintsRemaining = 3;
            btnHint.Text = "Hint (3)";
            btnHint.Enabled = true;

            btnAnswerA.Click -= btnAnswerA_Click;
            btnAnswerA.Click += btnAnswerA_Click;

            btnAnswerB.Click -= btnAnswerB_Click;
            btnAnswerB.Click += btnAnswerB_Click;

            btnAnswerC.Click -= btnAnswerC_Click;
            btnAnswerC.Click += btnAnswerC_Click;

            btnAnswerD.Click -= btnAnswerD_Click;
            btnAnswerD.Click += btnAnswerD_Click;

            btnHint.Click -= btnHint_Click;
            btnHint.Click += btnHint_Click;

            btnPause.Click -= btnPause_Click;
            btnPause.Click += btnPause_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;

            gameTimer.Interval = 1000;
            gameTimer.Stop();

            gameTimer.Tick -= gameTimer_Tick;
            gameTimer.Tick += gameTimer_Tick;

            currentQuestion = 0;

            LoadQuestion();
            UpdateTimerDisplay();

            gameTimer.Start();
        }

        private void AddQuestion(
            string question,
            string a,
            string b,
            string c,
            string d,
            int answer,
            string hint)
        {
            allQuestions.Add(
                new Question(question, a, b, c, d, answer, hint)
            );
        }

        private void SetQuestions(string difficulty)
        {
            allQuestions.Clear();
            questions.Clear();
            reserveQuestions.Clear();

            if (difficulty == "Easy")
            {
                remainingTime = 600;

                AddQuestion("What does CPU stand for?",
                    "Central Processing Unit", "Computer Personal Unit",
                    "Central Program Utility", "Control Processing User",
                    0, "It is the main processing component.");

                AddQuestion("Which device is used to type text?",
                    "Monitor", "Keyboard", "Speaker", "Printer",
                    1, "You use it to enter letters and numbers.");

                AddQuestion("What does RAM stand for?",
                    "Read Access Memory", "Random Access Memory",
                    "Run Application Memory", "Real Active Memory",
                    1, "It is temporary computer memory.");

                AddQuestion("Which device displays computer output?",
                    "Mouse", "Keyboard", "Monitor", "Scanner",
                    2, "It displays images and information.");

                AddQuestion("What is the brain of the computer?",
                    "CPU", "Mouse", "Printer", "Speaker",
                    0, "It processes instructions and data.");

                AddQuestion("Which device moves the cursor?",
                    "Monitor", "Printer", "Mouse", "Speaker",
                    2, "You control it using your hand.");

                AddQuestion("What does USB stand for?",
                    "Universal Serial Bus", "United System Board",
                    "Universal System Backup", "User Storage Base",
                    0, "It is a common connection port.");

                AddQuestion("Which of these is an input device?",
                    "Monitor", "Keyboard", "Speaker", "Printer",
                    1, "It is used to enter information.");

                AddQuestion("Which device produces printed documents?",
                    "Scanner", "Printer", "Mouse", "Microphone",
                    1, "It produces hard copies.");

                AddQuestion("What does ROM stand for?",
                    "Read Only Memory", "Random Only Memory",
                    "Run Output Memory", "Read Open Memory",
                    0, "It stores permanent instructions.");

                AddQuestion("Which one is an operating system?",
                    "Microsoft Word", "Windows", "Google Chrome", "Photoshop",
                    1, "It manages computer hardware and software.");

                AddQuestion("Which program is used to browse the internet?",
                    "Google Chrome", "Calculator", "Notepad", "Paint",
                    0, "It is a popular web browser.");

                AddQuestion("Which device stores files permanently?",
                    "RAM", "CPU", "HDD", "Monitor",
                    2, "It is a storage device.");

                AddQuestion("What does Wi-Fi allow devices to do?",
                    "Connect to wireless networks", "Print documents",
                    "Scan images", "Play CDs",
                    0, "It connects devices without cables.");

                AddQuestion("Which key creates a space?",
                    "Enter", "Shift", "Spacebar", "Caps Lock",
                    2, "It is the longest key on the keyboard.");

                AddQuestion("Which of these is application software?",
                    "Microsoft Word", "CPU", "RAM", "Motherboard",
                    0, "It is used for creating documents.");

                AddQuestion("Which device produces sound output?",
                    "Keyboard", "Speaker", "Mouse", "Scanner",
                    1, "It allows you to hear audio.");

                AddQuestion("Which file extension is commonly used for Word documents?",
                    ".mp3", ".jpg", ".docx", ".mp4",
                    2, "It is associated with Microsoft Word.");

                AddQuestion("Which keyboard key deletes characters?",
                    "Shift", "Backspace", "Caps Lock", "Tab",
                    1, "It removes characters before the cursor.");

                AddQuestion("Which component connects computer parts?",
                    "Motherboard", "Mouse", "Speaker", "Printer",
                    0, "It is the main circuit board.");
            }
            else if (difficulty == "Normal")
            {
                remainingTime = 420;

                AddQuestion("Which of the following is an operating system?",
                    "Microsoft Word", "Windows", "Google Chrome", "Photoshop",
                    1, "It manages computer hardware and software.");

                AddQuestion("What is the main function of a motherboard?",
                    "Display images", "Print documents",
                    "Connect computer components", "Play music",
                    2, "It connects the major computer components.");

                AddQuestion("Which device connects a computer to a network?",
                    "Monitor", "Keyboard", "Network Interface Card", "Speaker",
                    2, "It allows network communication.");

                AddQuestion("What does URL stand for?",
                    "Uniform Resource Locator", "Universal Record Link",
                    "User Reference Location", "United Resource Line",
                    0, "It is the address of a webpage.");

                AddQuestion("Which storage device uses flash memory?",
                    "HDD", "SSD", "DVD", "CD",
                    1, "It has no moving mechanical parts.");

                AddQuestion("What does HTML stand for?",
                    "HyperText Markup Language", "HighText Machine Language",
                    "Hyper Transfer Main Language", "Home Tool Markup Language",
                    0, "It structures web pages.");

                AddQuestion("Which protocol is used to send emails?",
                    "HTTP", "SMTP", "FTP", "DNS",
                    1, "It handles outgoing email.");

                AddQuestion("What is the main purpose of antivirus software?",
                    "Create presentations", "Remove malicious software",
                    "Edit photos", "Browse websites",
                    1, "It protects computers from malware.");

                AddQuestion("What does LAN stand for?",
                    "Local Area Network", "Large Access Network",
                    "Long Area Node", "Local Access Number",
                    0, "It connects computers in a limited area.");

                AddQuestion("Which software is used to manage databases?",
                    "Microsoft Access", "Paint", "Notepad", "Calculator",
                    0, "It helps organize stored information.");

                AddQuestion("What is the function of an IP address?",
                    "Identify a device on a network", "Increase screen brightness",
                    "Store pictures", "Print documents",
                    0, "It identifies a device on a network.");

                AddQuestion("Which programming language makes websites interactive?",
                    "JavaScript", "Microsoft Word", "PowerPoint", "Paint",
                    0, "It is commonly used in web development.");

                AddQuestion("What does GUI stand for?",
                    "Graphical User Interface", "General User Internet",
                    "Global Utility Interface", "Graphic Universal Input",
                    0, "It uses visual elements to interact with computers.");

                AddQuestion("Which component handles graphics processing?",
                    "CPU", "GPU", "RAM", "Power Supply",
                    1, "It processes images and graphics.");

                AddQuestion("What is cloud computing?",
                    "Using remote internet-based computing resources",
                    "Playing offline games", "Printing documents",
                    "Typing without a keyboard",
                    0, "It uses remote servers through the internet.");

                AddQuestion("Which device converts digital signals for network communication?",
                    "Modem", "Keyboard", "Printer", "Monitor",
                    0, "Its name comes from modulation and demodulation.");

                AddQuestion("What does HTTP stand for?",
                    "HyperText Transfer Protocol", "High Transfer Text Program",
                    "Hyper Tool Transfer Process", "Home Text Transmission Protocol",
                    0, "It is used for communication on the web.");

                AddQuestion("Which type of software manages computer resources?",
                    "System Software", "Game Software",
                    "Drawing Software", "Presentation Software",
                    0, "Operating systems belong to this category.");

                AddQuestion("What is phishing?",
                    "A method of stealing information through deception",
                    "A computer cleaning process", "A file compression method",
                    "A programming language",
                    0, "It often uses fake emails or websites.");

                AddQuestion("Which database language retrieves information?",
                    "SQL", "HTML", "CSS", "XML",
                    0, "It is used to query databases.");
            }
            else if (difficulty == "Hard")
            {
                remainingTime = 300;

                AddQuestion("Which data structure follows the LIFO principle?",
                    "Queue", "Stack", "Array", "Tree",
                    1, "The last item added is the first removed.");

                AddQuestion("What is the binary equivalent of decimal 10?",
                    "1010", "1001", "1100", "1110",
                    0, "Convert decimal 10 into base 2.");

                AddQuestion("Which protocol is used for secure web communication?",
                    "HTTP", "FTP", "HTTPS", "SMTP",
                    2, "It encrypts browser-server communication.");

                AddQuestion("What does SQL stand for?",
                    "Structured Query Language", "Simple Question Language",
                    "System Query Logic", "Standard Quick Language",
                    0, "It is used to manage databases.");

                AddQuestion("Which algorithm finds the shortest path in a weighted graph?",
                    "Bubble Sort", "Binary Search",
                    "Dijkstra's Algorithm", "Linear Search",
                    2, "It finds the shortest path in a weighted graph.");

                AddQuestion("What is the time complexity of binary search?",
                    "O(n)", "O(log n)", "O(n²)", "O(1)",
                    1, "The search space is divided in half.");

                AddQuestion("Which data structure follows FIFO?",
                    "Stack", "Queue", "Tree", "Graph",
                    1, "The first item added is the first removed.");

                AddQuestion("What does OOP stand for?",
                    "Object-Oriented Programming", "Online Operating Program",
                    "Object Output Process", "Open Office Programming",
                    0, "It is a programming approach based on objects.");

                AddQuestion("Which sorting algorithm compares adjacent elements?",
                    "Merge Sort", "Quick Sort", "Bubble Sort", "Binary Search",
                    2, "It repeatedly checks neighboring elements.");

                AddQuestion("What is the hexadecimal equivalent of decimal 15?",
                    "A", "B", "F", "E",
                    2, "It is the hexadecimal digit after E.");

                AddQuestion("Which normal form eliminates partial dependencies?",
                    "First Normal Form", "Second Normal Form",
                    "Third Normal Form", "Fourth Normal Form",
                    1, "It removes partial dependency on a composite key.");

                AddQuestion("What is the purpose of DNS?",
                    "Translate domain names into IP addresses",
                    "Store passwords", "Compress files", "Control the CPU",
                    0, "It converts website names into numerical addresses.");

                AddQuestion("Which protocol automatically assigns IP addresses?",
                    "HTTP", "FTP", "DHCP", "SMTP",
                    2, "It automatically provides network configuration.");

                AddQuestion("What is the smallest unit of digital information?",
                    "Byte", "Bit", "Kilobyte", "Megabyte",
                    1, "It is represented by 0 or 1.");

                AddQuestion("Which memory is volatile?",
                    "ROM", "SSD", "RAM", "Hard Drive",
                    2, "Its data is lost when power is turned off.");

                AddQuestion("What does API stand for?",
                    "Application Programming Interface",
                    "Advanced Program Internet",
                    "Application Process Integration",
                    "Automated Programming Input",
                    0, "It allows software applications to communicate.");

                AddQuestion("Which language is used to style web pages?",
                    "HTML", "CSS", "SQL", "Python",
                    1, "It controls the appearance of web pages.");

                AddQuestion("What is the primary function of a compiler?",
                    "Translate source code into machine code",
                    "Browse the internet", "Store database records",
                    "Create computer networks",
                    0, "It translates programming instructions.");

                AddQuestion("Which topology connects all devices to a central device?",
                    "Ring", "Bus", "Star", "Mesh",
                    2, "All devices connect to one central point.");

                AddQuestion("What is the default port number for HTTPS?",
                    "21", "25", "80", "443",
                    3, "It is the secure web communication port.");
            }
            else
            {
                MessageBox.Show("Invalid difficulty selected.");
                remainingTime = 600;

                AddQuestion("What does CPU stand for?",
                    "Central Processing Unit", "Computer Personal Unit",
                    "Central Program Utility", "Control Processing User",
                    0, "It is the main processing component.");
            }

            SelectRandomQuestions();
        }

        private void SelectRandomQuestions()
        {
            List<Question> shuffled = new List<Question>(allQuestions);

            for (int i = shuffled.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Question temp = shuffled[i];
                shuffled[i] = shuffled[j];
                shuffled[j] = temp;
            }

            for (int i = 0; i < shuffled.Count; i++)
            {
                if (i < 10)
                    questions.Add(shuffled[i]);
                else
                    reserveQuestions.Add(shuffled[i]);
            }
        }

        private void LoadQuestion()
        {
            if (currentQuestion >= questions.Count)
                return;

            Question q = questions[currentQuestion];

            lblQuestionNumber.Text =
                "Question " + (currentQuestion + 1) +
                " / " + questions.Count;

            lblQuestion.Text = q.Text;

            btnAnswerA.Text = "A. " + q.Choices[0];
            btnAnswerB.Text = "B. " + q.Choices[1];
            btnAnswerC.Text = "C. " + q.Choices[2];
            btnAnswerD.Text = "D. " + q.Choices[3];
        }

        private void CheckAnswer(int selectedAnswer)
        {
            if (gameEnded || isPaused)
                return;

            if (selectedAnswer == questions[currentQuestion].CorrectAnswer)
            {
                MessageBox.Show(
                    "Correct Answer!",
                    "ESCAPE COMLAB",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                currentQuestion++;

                if (currentQuestion >= questions.Count)
                    WinGame();
                else
                    LoadQuestion();
            }
            else
            {
                remainingTime -= penaltySeconds;

                if (remainingTime < 0)
                    remainingTime = 0;

                UpdateTimerDisplay();

                MessageBox.Show(
                    "Incorrect Answer!\n30 seconds deducted.",
                    "WRONG ANSWER",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                if (remainingTime <= 0)
                    GameOver();
            }
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (gameEnded || isPaused)
                return;

            if (hintsRemaining > 0)
            {
                MessageBox.Show(
                    questions[currentQuestion].Hint,
                    "ESCAPE COMLAB - HINT",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                hintsRemaining--;

                btnHint.Text = "Hint (" + hintsRemaining + ")";

                if (hintsRemaining == 0)
                    btnHint.Enabled = false;
            }
            else
            {
                MessageBox.Show("You have used all your hints!");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (gameEnded)
                return;

            if (!isPaused)
            {
                gameTimer.Stop();

                isPaused = true;
                btnPause.Text = "Resume";
            }
            else
            {
                isPaused = false;
                btnPause.Text = "P";

                gameTimer.Start();
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameEnded || isPaused)
                return;

            remainingTime--;

            UpdateTimerDisplay();

            if (remainingTime <= 0)
                GameOver();
        }

        private void UpdateTimerDisplay()
        {
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;

            lblTimer.Text = string.Format(
                "Time: {0:00}:{1:00}",
                minutes,
                seconds
            );
        }

        private void StopMusic()
        {
            if (music != null)
            {
                music.Stop();
                music.Dispose();
                music = null;
            }
        }

        private void GameOver()
        {
            if (gameEnded)
                return;

            gameEnded = true;
            gameTimer.Stop();
            StopMusic();

            MessageBox.Show(
                "Time is up!\nYou failed to escape the computer laboratory.",
                "GAME OVER",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            mainMenu.Show();
            this.Close();
        }

        private void WinGame()
        {
            if (gameEnded)
                return;

            gameEnded = true;
            gameTimer.Stop();
            StopMusic();

            MessageBox.Show(
                "Congratulations!\nYou successfully escaped the computer laboratory!",
                "YOU ESCAPED!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            mainMenu.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gameEnded)
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to leave the game?",
                "BACK TO MENU",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                gameEnded = true;
                gameTimer.Stop();
                StopMusic();

                mainMenu.Show();
                this.Close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
