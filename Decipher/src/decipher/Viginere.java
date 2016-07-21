package decipher;

/**
 * Class for encoding and decoding text modeled off of a viginere cipher
 */
public class Viginere {
    
    private String key;
    
    public Viginere(String key){
        this.key = key;
    }
    
    //encodes a string against the set key
    public String encode(String message){
        
        String output = "";
        for(int i = 0; i < message.length(); i++){
            char letter = message.charAt(i);
            char keyValue = key.charAt(i % key.length());
            // converts chars to values from 0-25
            int l = letter-65;
            int k = keyValue -65;
            char  x = (char) ((l+k)%26 + 65);
            output += x;   
        }
        return output;
    }
    
    //decodes a given string based off key
    public String decode(String input){
        
        String message = "";
        for(int i = 0; i < input.length(); i++){
            char letter = input.charAt(i);
            char keyValue = key.charAt(i % key.length());
            // converts chars to values from 0-25
            int l = letter-65;
            int k = keyValue -65;
            int diff = l-k;
            if (diff < 0){
                diff = Math.abs(diff); //dont know why plus two works but it works
            }
            char  x = (char) (diff%26 + 65);
            message += x;   
        }
        return message;
    }
    
    //sets the key
    public void setKey(String key){
        this.key = key;
    }
}
