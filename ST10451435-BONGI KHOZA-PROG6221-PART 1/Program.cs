using System.Media;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System;
using System.Windows.Forms;

class CyberSecurityAwarenessBot
{
    // Neon Color Console Extension
    private static class NeonColors
    {
        public static readonly ConsoleColor NeonPink = ConsoleColor.Magenta;
        public static readonly ConsoleColor NeonGreen = ConsoleColor.Green;
        public static readonly ConsoleColor NeonBlue = ConsoleColor.Blue;
        public static readonly ConsoleColor NeonYellow = ConsoleColor.Yellow;
        public static readonly ConsoleColor NeonCyan = ConsoleColor.Cyan;
        public static readonly ConsoleColor NeonRed = ConsoleColor.Red;
        public static readonly ConsoleColor SkyBlue = ConsoleColor.Cyan; // Sky blue color
    }

    // Cybersecurity Topics Dictionary
    private static Dictionary<int, (string Topic, string Description)> cyberTopics = new Dictionary<int, (string, string)>
    {
        {1, ("Password Security", "Learn how to create and manage strong, unbreakable passwords")},
        {2, ("Phishing Awareness", "Identify and protect yourself from online scams and fraudulent attempts")},
        {3, ("Social Media Safety", "Protect your personal information and privacy on social platforms")},
        {4, ("Two-Factor Authentication", "Understand the importance of additional security layers")},
        {5, ("WiFi and Network Security", "Safeguard your online connections and personal data")},
        {6, ("Email Safety", "Recognize and prevent email-based cyber threats")},
        {7, ("Personal Data Protection", "Strategies to keep your personal information secure online")},
        {8, ("Online Shopping Safety", "Protect yourself from fraud during online transactions")}
    };

    // Neon Cybersecurity Awareness Bot Logo with Sky Blue text on Neon Pink background
    private static void DisplayLogo()
    {
        // Set background to Neon Pink
        Console.BackgroundColor = NeonColors.NeonPink;

        // Set foreground to Sky Blue
        Console.ForegroundColor = NeonColors.SkyBlue;

        Console.WriteLine(@"

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
******************************************************************************************************** ~
^             ^                         ^                                 ^                     ^      * ~
 ██████╗██╗   ██╗██████╗ ███████╗██████╗      ███████╗ █████╗ ███████╗███████╗████████╗██╗   ██╗       * ~
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗     ██╔════╝██╔══██╗██╔════╝██╔════╝╚══██╔══╝╚██╗ ██╔╝       * ~
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝     ███████╗███████║█████╗  █████╗     ██║    ╚████╔╝        * ~
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗     ╚════██║██╔══██║██╔══╝  ██╔══╝     ██║     ╚██╔╝         * ~
╚██████╗   ██║   ██████╔╝███████╗██║  ██║     ███████║██║  ██║██║     ███████╗   ██║      ██║  ^       * ~
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝     ╚══════╝   ╚═╝      ╚═╝          * ~
                 ^                              ^                                                   ^  * ~
        ^                   🔒 NEON CYBER GUARDIAN 🛡️          ^                                      * ~
                     ^                                                             ^                   * ~
   ^                                    ^                         ^                                  ^ * ~
******************************************************************************************************** ~
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
");
        // Reset console colors to default
        Console.ResetColor();
    }

    // Voice Greeting Simulation with error handling
    private static void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer soundPlayer = new SoundPlayer("Cyber (online-audio-converter.com).wav");
            soundPlayer.Load();
            soundPlayer.PlaySync();
        }
        catch (Exception ex)
        {
            // Gracefully handle missing audio file or other sound issues
            Console.ForegroundColor = NeonColors.NeonYellow;
            Console.WriteLine("[Audio system notice: Continuing in text mode]");
            Console.ResetColor();
        }

        Console.ForegroundColor = NeonColors.SkyBlue;
        Console.WriteLine(" HELLO :) WELCOME TO CYBER SECURITY AWARENESS CHATBOT!! MY NAME IS CYBER SAFETY, PLEASE ENTER YOURS TO CONTINUE.");
        Console.ResetColor();

        string userText = Console.ReadLine();

        Console.ForegroundColor = NeonColors.NeonBlue;
        Console.WriteLine("\n[🔊 Quantum Voice Activation System]");
        Console.ResetColor();

        string[] voiceSounds = {
            "⚡ Neon Circuits Initializing...",
            "🌈 Cyber Wavelengths Calibrating...",
            "🔮 Holographic Security Interface Online!"
        };

        foreach (var sound in voiceSounds)
        {
            Console.ForegroundColor = NeonColors.NeonCyan;
            Console.WriteLine(sound);
            Console.ResetColor();
            Thread.Sleep(600);
        }
    }

    // Display Topics Menu
    private static void DisplayTopicsMenu()
    {
        Console.ForegroundColor = NeonColors.NeonGreen;
        Console.WriteLine("\n🌐 CYBER SAFETY TOPICS MENU 🛡️");
        Console.ResetColor();

        foreach (var topic in cyberTopics)
        {
            Console.ForegroundColor = NeonColors.NeonYellow;
            Console.WriteLine($"{topic.Key}. {topic.Value.Topic}");
            Console.ForegroundColor = NeonColors.NeonBlue;
            Console.WriteLine($"   {topic.Value.Description}\n");
        }
        Console.ForegroundColor = NeonColors.NeonRed;
        Console.WriteLine("0. Exit Cyber Safety Guardian");
        Console.ResetColor();
    }

    // Detailed Topic Information
    private static void ShowTopicDetails(int topicChoice)
    {
        // Create a dictionary mapping topic choices to their detailed information
        Dictionary<int, string> topicDetails = new Dictionary<int, string>
    {
        {1, @"🔐 ADVANCED PASSWORD SECURITY:
- Create passwords 16+ characters long
- Use a mix of uppercase, lowercase, numbers, symbols
- Avoid personal information (birthdays, names)
- Use unique passwords for each account
- Utilize password manager
- Enable password strength checkers
- Consider passphrase method"},

        {2, @"🎣 PHISHING DEFENSE STRATEGIES:
- Verify sender's email address carefully
- Look for suspicious links or attachments
- Check for spelling and grammatical errors
- Never share personal info via email
- Use email filtering tools
- Implement anti-phishing browser extensions
- Report suspicious emails to IT or platform"},

        {3, @"🌐 SOCIAL MEDIA PROTECTION:
- Set profiles to private
- Be selective with friend/connection requests
- Limit personal information shared
- Use strong, unique passwords
- Enable two-factor authentication
- Review app permissions regularly
- Be cautious of location sharing
- Think before posting personal content"},

        {4, @"🔒 TWO-FACTOR AUTHENTICATION GUIDE:
- Prefer authenticator apps over SMS
- Use multiple 2FA methods when possible
- Keep backup codes in secure location
- Avoid using the same 2FA method everywhere
- Update 2FA settings regularly
- Consider hardware security keys
- Be aware of 2FA recovery processes"},

        {5, @"📡 NETWORK AND WIFI SECURITY:
- Use VPN on public networks
- Disable auto-connect to unknown networks
- Use WPA3 encryption at home
- Change router default passwords
- Update router firmware
- Use guest networks for visitors
- Disable remote management
- Use MAC address filtering"},

        {6, @"📧 EMAIL SAFETY PROTOCOLS:
- Use email encryption
- Be wary of unexpected attachments
- Use separate emails for different purposes
- Enable spam and phishing filters
- Use disposable email for online registrations
- Regularly clean up email subscriptions
- Be cautious of urgent or threatening emails
- Verify sender's identity"},

        {7, @"🔐 PERSONAL DATA PROTECTION:
- Minimize personal info shared online
- Use privacy-focused browsers
- Regularly check privacy settings
- Be cautious of online quizzes and surveys
- Use privacy protection services
- Monitor credit reports
- Use encrypted messaging apps
- Be careful with online forms"},

        {8, @"💳 ONLINE SHOPPING SECURITY:
- Shop on secure, verified websites
- Look for HTTPS and lock icon
- Use credit cards over debit
- Enable transaction alerts
- Use virtual credit card numbers
- Avoid public WiFi for transactions
- Check website authenticity
- Use trusted payment methods
- Keep software and browser updated"}
    };

        // Get the detailed information or provide a default message
        string detailedInfo = topicDetails.ContainsKey(topicChoice)
            ? topicDetails[topicChoice]
            : "Invalid topic selection. Please choose a valid option.";

        Console.ForegroundColor = NeonColors.NeonCyan;
        Console.WriteLine($"\n🔒 DETAILED CYBER INTELLIGENCE FOR TOPIC:");
        Console.ForegroundColor = NeonColors.NeonBlue;
        Console.WriteLine(detailedInfo);
        Console.ResetColor();
    }

    // Main Interaction with improved error handling
    private static void StartChatSession(string userName)
    {
        // Validate username input
        userName = string.IsNullOrWhiteSpace(userName) ? "Cyber Agent" : userName;

        Console.ForegroundColor = NeonColors.NeonGreen;
        Console.WriteLine($"\n👤 Welcome, {userName}! How are you doing today?");
        Console.ResetColor();
        Console.ReadLine(); // Allow user to respond

        while (true)
        {
            DisplayTopicsMenu();

            Console.ForegroundColor = NeonColors.NeonYellow;
            Console.Write("\n🔍 Enter topic number for more information (0 to exit): ");
            Console.ResetColor();

            if (!int.TryParse(Console.ReadLine(), out int topicChoice))
            {
                Console.ForegroundColor = NeonColors.NeonRed;
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ResetColor();
                continue;
            }

            if (topicChoice == 0)
            {
                Console.ForegroundColor = NeonColors.NeonPink;
                Console.WriteLine($"\n🛡️ Stay safe online, {userName}! Cyber Guardian logging out... 🌈");
                break;
            }

            if (cyberTopics.ContainsKey(topicChoice))
            {
                ShowTopicDetails(topicChoice);
            }
            else
            {
                Console.ForegroundColor = NeonColors.NeonRed;
                Console.WriteLine("Invalid topic number. Please choose from the menu.");
                Console.ResetColor();
            }

            Console.ForegroundColor = NeonColors.NeonGreen;
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Title = "Neon Cyber Safety Guardian";
        }
        catch
        {
            // Silently handle if console title can't be set
        }

        try
        {
            Console.WindowWidth = Math.Max(Console.WindowWidth, 120);
        }
        catch
        {
            // Handle case where console window size cannot be changed
            Console.WriteLine("Notice: For best experience, maximize your console window.");
        }

        try
        {
            DisplayLogo();
            PlayVoiceGreeting();

            Console.ForegroundColor = NeonColors.NeonGreen;
            Console.Write("\n👤 CYBER AGENT IDENTIFICATION > ");
            Console.ResetColor();

            string userName = Console.ReadLine();
            StartChatSession(userName);
        }
        catch (Exception ex)
        {
            // Global exception handler
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[SYSTEM ERROR] Something went wrong. Please restart the application.");
            Console.WriteLine("Error details (for debugging): " + ex.Message);
            Console.ResetColor();

            // Wait for user acknowledgment before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
