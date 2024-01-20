using System;
public class PromptGenerator
{
        public List<string> _prompts = new List<string>
        {
                "Describe a place where you felt happiest. ",
                "What was your greatest fear, and how did you conquer it?",
                "Write a letter to someone that you always want to thank but have never had the chance to do so.",
                "What is something that you would like to change about yourself? How can you change it?",
                "What are three qualities you admire in yourself?",
                "How do you define success, and what does it look like for you?",
                "Describe a recent situation where you felt proud of yourself and explain why.",
                "List five things you are grateful for today and explain why.",
                "Describe a small act of kindness you witnessed or performed recently.",
                "Reflect on a challenging situation and find something positive or a lesson you learned from it.",
                "What is one fear or limiting belief you want to overcome, and how can you work towards it?",
                "Write about a new skill or hobby you would like to develop and why it interests you.",
        };



        public void Display()
        {
                var random = new Random();
                int index = random.Next(_prompts.Count);
                string prompt = _prompts[index];
                Console.WriteLine($"\n{_prompts}");
        }
        public string GetRandomPrompt()
        {
                var random = new Random();
                int index = random.Next(_prompts.Count);
                string prompt = _prompts[index];
                
                return prompt;
    
        }
        
}