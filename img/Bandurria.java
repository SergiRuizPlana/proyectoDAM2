package problemes;


import java.util.Scanner;

public class Bandurria {
	
public static void main(String[]args) {
	
	Scanner lector = new Scanner(System.in);
		
	int cont=0;
	int combo = 0;
	int prob = 0;
	int res = 0;
	String cadena = "";
	
	prob = lector.nextInt();
	

	
	int result[] = new int[prob];
	
	while(cont < prob) {
		
		cadena = lector.next();
		String lletra[]  = new String[cadena.length()];
		
		
		for (int i = 0; i < cadena.length();i++) {
			lletra = cadena.split("");
			if (lletra[i].equals("O")) {
				
				combo = combo + 10;
				res = res+combo;
				
			} else if (lletra[i].equals(".")) {
				combo = 0;
			}
			
			
		}
		result[cont] = res;
			cont = cont+1;
			res = 0;
	}
	
	for (int i = 0; i < prob; i++) {
		System.out.println(result[i]);
	}
	
	
	}
	

}
