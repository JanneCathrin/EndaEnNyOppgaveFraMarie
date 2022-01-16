using System;

namespace EndaEnNyOppgaveFraMarie
{
    class Program
    {
        static void Main(string[] args) { }

    }
}










/* Lag et interface som heter IPokemon som har en property Health og en metode LooseHealth()
Lag en klasse Magicarp som har en property IsUseless og en metode som heter Splash.
Lag en annen Klasse med din favoritt pokemon, og metoder som heter det samme som attacktypene til pokemonen du har valgt.I attackmetodene skal du ta inn en IPokemon som parameter og kalle den sin LooseHealth metode.
Magicarp og din favorittpokemon klasse skal begge arve fra IPokemon og begge må ha sin egen constructor som setter health. 
I program.cs, lag en ny magicarp og en ny av din favoritt pokemon.Definer en while(true) løkke som kaller på magicarp.Splash() og din pokemon sine forskjellige attack metoder.
Programmet kan avsluttes når magicarp har <= 0 i health*\