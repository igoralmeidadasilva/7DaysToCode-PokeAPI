using System;

namespace model
{
    public class Mascote
    {
        
        public string? Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        private int _fome;
        
        private int _humor;
        
        private int _sono;

        public List<AbilitiesClass>? abilities { get; set; }
        public Mascote()
        {
            _fome = new Random().Next(1,30);
            _humor = new Random().Next(1,30);
            _sono = new Random().Next(1,30);
        }

        public int Fome
        { 
            get { return _fome; } 
            set {
                if(value > 0 && value <= 100){
                    _fome = value;
                } else {
                    Console.WriteLine("Valor inválido!");
                }
            }
        }
        public int Sono 
        { 
            get { return _sono; } 
            set {
                if(value > 0 && value <= 100){
                    _sono = value;
                } else {
                    Console.WriteLine("Valor inválido!");
                }
            } 
        }
        public int Humor
        { 
            get { return _humor; } 
            set {
                if(value > 0 && value <= 100){
                    _humor = value;
                } else {
                    Console.WriteLine("Valor inválido!");
                }
            } 
        }
        public override string? ToString()
        {
            return $"Nome: {Name}\n" +
                   $"Altura: {Weight}\n" +
                   $"Peso: {Height}\n" +
                   $"Fome: {_fome}\n" +
                   $"Humor: {_humor}\n" +
                   $"Sono: {_sono}\n";
        }

        public void showAbilities (){
            if(this.abilities != null){
                Console.WriteLine("HABILIDADES:");
                foreach (var item in abilities)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Brincar()
        {
            _fome -= 30;
            _sono -= 30;
            _humor += 60;
            Console.WriteLine($"{Name} se divertiu brincando.");
        }
        public void Comer(Berry berry)
        {
            _fome += 60;
            _sono -= 30;
            Console.WriteLine($"{Name} comeu uma {berry.name}");
        }
        public void Dormir()
        {
            _sono += 80;
            _fome -= 30;
            Console.WriteLine($"{Name} descançou");
        }

        public void Status()
        {
            if(_humor < 30 ){
                Console.WriteLine($"{Name} está infeliz.");
            } else if (_humor >=30 && _humor < 80 ){
                Console.WriteLine($"{Name} está alegre.");
            } else {
                Console.WriteLine($"{Name} está muito feliz. \0/");
            }

            if(_fome < 30) {
                Console.WriteLine($"{Name} está faminto.");
            } else if (_fome >=30 && _fome < 80 ){
                Console.WriteLine($"{Name} está com alguma fome.");
            } else {
                Console.WriteLine($"{Name} está bem alimentado. =p");
            }

            if(_sono < 30){
                Console.WriteLine($"{Name} está com muito sono.");
            } else if (_sono >=30 && _sono < 80 ){
                Console.WriteLine($"{Name} está com sono.");
            } else {
                Console.WriteLine($"{Name} está cheio de energia. =p");
            }
        }
    }
}
