
package priority.queue;

import java.util.Arrays;
import javax.swing.DefaultListModel;
import javax.swing.JList;

/**
 *
 * A queue of patients, can push and pop based on priority
 */
public class PatientQueue {
    
    public static int MAX_PATIENTS = 100;
    
    private Patient[] patients;
    
    public PatientQueue(){
        patients = new Patient[MAX_PATIENTS];
    }
    
    //checks if queue is full
    public boolean isFull(){
        return patients[99] == null;
    }
    
    //creates a new array with newPatient added to it
    public void Push(Patient newPatient){
        
        if(patients[99] == null){
            
            //new queue with newPatient at front
            Patient[] newQueue = new Patient[MAX_PATIENTS];
            newQueue[0] = newPatient;
        
            //loops thru old queue and adds each element
            for(int i = 0; i< patients.length; i++){
                newQueue[i+1] = patients[i];
            }
        
            //sets newQueue
            patients = newQueue; 
        
            System.out.println("Patient: " + newPatient.getName() + " has been successfully added to list");
            
        }else{
            System.out.println("Patient Queue is full, push attempt failed");
        }
             
    }
    
    //pops the patient in the list with highest priority if list conatins patients
    public Patient PriorityPop(){
        
        Arrays.sort(patients);
        Patient highestPriorityPatient = patients[0];
        
        if(patients[0] != null){
        
            for(int i = 0; i < MAX_PATIENTS; i++){
                if(patients[i].getPriority() > highestPriorityPatient.getPriority()){
                    highestPriorityPatient = patients[i];
                }
            }
            
            System.out.println("Patient popped");
            
        }else{
            
            System.out.println("Patient Queue is empty, null patient popped");
            
        }
       
        return highestPriorityPatient;
    }
    
    public void PrintToListBox(JList jl){
        jl = new JList<String>(new DefaultListModel<String>());
        for(Patient p : patients){
            jl.add ;
        }
    }
    
}
