using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeManos
{
    internal class Pokemon
    {
        //características individuais
        string nome;
        string[] tipo = new string[4];
        string especie;
        int natureza;
        string[] moves = new string[4];
        int level;
        double[] atributes = new double[6];
        double printIV;
        int[] iv = new int[6];
        Random values = new Random();
        int initial;

        //características influenciaveis
        int vida;

        //Pokémons ativos/ na bolsa
        string[] pkmAtivo = new string[6];

        //Pokémons no PC
        string[] pkmPc = new string[60];

        //características gerais/randômicas
        string[,] species = new string[50, 2];

        //Começo dos métodos

        //Seleção de iniciais
        public int iniciais(int inicial)
        {
            switch (inicial)
            {
                case 1:
                    pkmAtivo[inicial - 1] = "fogo 1";
                    initial = inicial;
                    break;

                case 2:
                    pkmAtivo[inicial - 1] = "água 1";
                    initial = inicial;
                    break;

                case 3:
                    pkmAtivo[inicial - 1] = "planta 1";
                    initial = inicial;
                    break;

                default:
                    inicial = 0;
                    break;
            }
            return initial;
        }

        //Método construtor do pokémon(inicial)
        public Pokemon(string name, int initial) 
            {
            switch (initial) 
                {
                case 1:
                    nome = name;
                    tipo[0] = "Fogo";
                    especie = "Charmander";
                    natureza = values.Next(1, 25);
                    level = 1;
                    break;
                case 2:
                    nome = name;
                    tipo[0] = "Água";
                    especie = "Squirtle";
                    natureza = values.Next(1, 25);
                    level = 1;
                    break;  
                case 3:
                    nome = name;
                    tipo[0] = "Planta";
                    especie = "Bulbasaur";
                    natureza = values.Next(1, 25);
                    level = 1;
                    break;  
                }
            }

        //Método construtor do pokémon(sem parâmetro)
        public Pokemon() { }

        //Vai gerar os atributos base de cada pokémon
        private void gerarAtributos() 
        {
            /* 
             0 = HP 
             1 = ATK
             2 = DEF
             3 = SP. ATK
             4 = SP. DEF
             5 = SPD  
             */
            if (especie == "Charmander")
            {
                atributes[0] = 39;
                atributes[1]=52;
                atributes[2]=43;
                atributes[3]=60;
                atributes[4]=50;
                atributes[5]=65;
            }
            if (especie == "Bulbasaur")
            {

            }
        }
        public enum PokemonEspecie
        {
            Charmander = 1, Charmeleon = 2, Charizard = 3,
            Bulbasaur = 4, Ivysaur = 5, Venusaur = 6,
            Squirtle = 7, Wartortle = 8, Blastoise = 9,
            Caterpie = 10, Metapod = 11, Butterfree = 12,
            Weedle = 13, Kakuna = 14, Beedrill = 15,
            Pidgey = 16, Pidgeotto = 17, Pidgeot = 18,
            Rattata = 19, Raticate = 20,
            Spearow = 21, Fearow = 22,
            Ekans = 23, Arbok = 24,
            Pikachu = 25, Raichu = 26,
            Sandshrew = 27, Sandslash = 28,
            Nidoran = 29, Nidorina = 30, Nidoqueen = 31,
            Nidoran = 32, Nidorino = 33, Nidoking = 34,
            Clefairy = 35, Clefable = 36,
            Vulpix = 37, Ninetales = 38,
            Jigglypuff = 39, Wigglytuff = 40,


    }
    private Dictionary<PokemonEspecie, PokemonAttributes> pokemonAttributes = new Dictionary<PokemonEspecie, PokemonAttributes>
    {
        { PokemonType.Charmander, new PokemonAttributes { HP = 39, ATK = 52, DEF = 43, SP_ATK = 60, SP_DEF = 50, SPD = 65 } },
        { PokemonType.Bulbasaur, new PokemonAttributes { HP = 45, ATK = 49, DEF = 49, SP_ATK = 65, SP_DEF = 65, SPD = 45 } },
        { PokemonType.Squirtle, new PokemonAttributes { HP = 44, ATK = 48, DEF = 65, SP_ATK = 50, SP_DEF = 64, SPD = 43 } },
        { PokemonType.Pikachu, new PokemonAttributes { HP = 35, ATK = 55, DEF = 40, SP_ATK = 50, SP_DEF = 50, SPD = 90 } }
        { PokemonType.Caterpie, new PokemonAttributes { HP = 45, ATK = 30, DEF = 35, SP_ATK = 20, SP_DEF = 20, SPD = 45 } },
        { PokemonType.Metapod, new PokemonAttributes { HP = 50, ATK = 20, DEF = 30, SP_ATK = 25, SP_DEF = 25, SPD = 45 } },
        { PokemonType.Butterfree, new PokemonAttributes { HP = 60, ATK = 45, DEF = 50, SP_ATK = 80, SP_DEF = 80, SPD = 70 } },
        { PokemonType.Weedle, new PokemonAttributes { HP = 40, ATK = 40, DEF = 40, SP_ATK = 40, SP_DEF = 40, SPD = 60 } },
        { PokemonType.Kakuna, new PokemonAttributes { HP = 45, ATK = 25, DEF = 30, SP_ATK = 35, SP_DEF = 35, SPD = 60 } },
        { PokemonType.Beedrill, new PokemonAttributes { HP = 65, ATK = 80, DEF = 40, SP_ATK = 45, SP_DEF = 80, SPD = 75 } },
        { PokemonType.Pidgey, new PokemonAttributes { HP = 45, ATK = 45, DEF = 40, SP_ATK = 35, SP_DEF = 35, SPD = 56 } },
        { PokemonType.Pidgeotto, new PokemonAttributes { HP = 63, ATK = 60, DEF = 30, SP_ATK = 35, SP_DEF = 35, SPD = 56 } },
        { PokemonType.Pidgeot, new PokemonAttributes { HP = 83, ATK = 80, DEF = 80, SP_ATK = 35, SP_DEF = 35, SPD = 56 } },
        { PokemonType.Rattata, new PokemonAttributes { HP = 45, ATK = 56, DEF = 35, SP_ATK = 35, SP_DEF = 35, SPD = 72 } },
        { PokemonType.Raticate, new PokemonAttributes { HP = 75, ATK = 81, DEF = 60, SP_ATK = 50, SP_DEF = 50, SPD = 97 } },
        { PokemonType.Spearow, new PokemonAttributes { HP = 45, ATK = 60, DEF = 30, SP_ATK = 31, SP_DEF = 31, SPD = 70 } },
        { PokemonType.Fearow, new PokemonAttributes { HP = 65, ATK = 90, DEF = 65, SP_ATK = 61, SP_DEF = 61, SPD = 100 } },
        { PokemonType.Ekans, new PokemonAttributes { HP = 55, ATK = 60, DEF = 44, SP_ATK = 40, SP_DEF = 40, SPD = 55 } },
        { PokemonType.Arbok, new PokemonAttributes { HP = 75, ATK = 95, DEF = 69, SP_ATK = 65, SP_DEF = 65, SPD = 80 } },
        { PokemonType.Sandshrew, new PokemonAttributes { HP = 50, ATK = 75, DEF = 85, SP_ATK = 20, SP_DEF = 30, SPD = 40 } },
        { PokemonType.Sandslash, new PokemonAttributes { HP = 75, ATK = 100, DEF = 110, SP_ATK = 45, SP_DEF = 55, SPD = 65 } },
        { PokemonType.Nidoran, new PokemonAttributes { HP = 70, ATK = 64, DEF = 50, SP_ATK = 45, SP_DEF = 40, SPD = 50 } },
        { PokemonType.Nidorina, new PokemonAttributes { HP = 70, ATK = 62, DEF = 67, SP_ATK = 55, SP_DEF = 55, SPD = 42 } },
        { PokemonType.Nidoqueen, new PokemonAttributes { HP = 90, ATK = 92, DEF = 87, SP_ATK = 75, SP_DEF = 85, SPD = 76 } },
        { PokemonType.Nidoran, new PokemonAttributes { HP = 90, ATK = 85, DEF = 90, SP_ATK = 75, SP_DEF = 60, SPD = 50 } },
        { PokemonType.Nidorino, new PokemonAttributes { HP = 90, ATK = 85, DEF = 60, SP_ATK = 75, SP_DEF = 60, SPD = 50 } },
        { PokemonType.Nidoking, new PokemonAttributes { HP = 90, ATK = 85, DEF = 60, SP_ATK = 85, SP_DEF = 60, SPD = 50 } },
        { PokemonType.Clefairy, new PokemonAttributes { HP = 70, ATK = 45, DEF = 48, SP_ATK = 60, SP_DEF = 65, SPD = 35 } },
        { PokemonType.Clefable, new PokemonAttributes { HP = 95, ATK = 70, DEF = 73, SP_ATK = 95, SP_DEF = 90, SPD = 60 } },
        { PokemonType.Vulpix, new PokemonAttributes { HP = 60, ATK = 41, DEF = 40, SP_ATK = 65, SP_DEF = 65, SPD = 65 } },
        { PokemonType.Ninetales, new PokemonAttributes { HP = 73, ATK = 76, DEF = 75, SP_ATK = 81, SP_DEF = 100, SPD = 100 } },
        { PokemonType.Jigglypuff, new PokemonAttributes { HP = 115, ATK = 45, DEF = 20, SP_ATK = 45, SP_DEF = 25, SPD = 20 } },
        { PokemonType.Wigglytuff, new PokemonAttributes { HP = 140, ATK = 70, DEF = 45, SP_ATK = 85, SP_DEF = 50, SPD = 45 } }
    };
    
    public void CriarPokemon(PokemonEspecie pokemonEspecie)
    {
        PokemonAttributes attributes = pokemonAttributes[pokemonType];
        this.attributes = new int[6];
        this.attributes[0] = attributes.HP;
        this.attributes[1] = attributes.ATK;
        this.attributes[2] = attributes.DEF;
        this.attributes[3] = attributes.SP_ATK;
        this.attributes[4] = attributes.SP_DEF;
        this.attributes[5] = attributes.SPD;
    }
}
