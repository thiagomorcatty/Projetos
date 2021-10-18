class Estudante { 

    int id; 
    
    /* String nome; */
    
    
    
    void display () {System.out.println (id + '' + nome);} 
    
    
    
        public static void main (String args []) { 
    
            Estudante estudante1 = new Estudante(); 
    
            Estudante estudante2 = new Estudante(); 
    
    
    
            estudante1.display (); 
    
            estudante1.display (); 
    
            } 
    
    } 


    public class Teste{ 

        public static void main(String[ ] args){ 
       
        HashMap<Sting,String> nomes = new HashMap<String,String>( ); 
       
        nomes.put(“chave1”,“teste”); 
       
        nomes.put(“chave2”,“gama academy”); 
       
        nomes.put(“chave3”,“gleyson”); 
       
        nomes.put(“chave4”,“rafael”); 
       
        nomes.put(“chave1',“filipe”); 
       
       
       
        System.out.println(nomes); 
       
        } 
       
        }