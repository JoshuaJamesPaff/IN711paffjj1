/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package decipher;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;

/**
 * program reads text and helps user decipher it
 * @author Joshua Paff
 */
public class Decipher {

    public static ArrayList<String> keys = new ArrayList();
    public static ArrayList<String> quotes = new ArrayList();
    /**
     * Main method reads text file and then loops thru quotes list testing possible key combinations
     */
    public static void main(String[] args) throws IOException {
        ReadText();
        Viginere cipher = new Viginere("BART");
        for(String key : keys){
            cipher.setKey(key);
            for(String quote : quotes){
                String output = key + ": " + cipher.decode(quote);
                System.out.println(output);
            }
        }
    }
    
    //reads the first 10 keys and first 10 quotes into 2 arraylists
    public static void ReadText() throws IOException{
        int counter = 0;
        for (String line : Files.readAllLines(Paths.get("ViginereTestInput.txt"))) {
            if(counter < 10){
                keys.add(line);
            }else{
                quotes.add(line);
            }
            counter++;
        }

    }
}
