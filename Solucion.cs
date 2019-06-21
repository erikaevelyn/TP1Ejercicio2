using System;
namespace EJERCICIO_2{
    /*Un palíndromo es una palabra que lee lo mismo hacia atrás o hacia adelante.
Escribe una función que verifique si una palabra dada es un palíndromo. El caso del personaje debe 
ser ignorado.
Por ejemplo, IsPalindrome ("Deleveled") debe devolver true, ya que el caso del carácter debe ignorarse, 
lo que da como resultado "deleveled", que es un palindrome ya que se lee igual hacia atrás y hacia 
adelante
 */
    public class Solucion{

        public bool IsPalindrome(string cadena){
            string minuscula = cadena.ToLower();
        	if(minuscula.Length < 2){
                return true;
            }
        	if(minuscula[0] == minuscula[cadena.Length - 1]){
                return IsPalindrome(minuscula.Substring(1, minuscula.Length - 2));
            } else {
                return false;
            }
        	
        }
    }
}