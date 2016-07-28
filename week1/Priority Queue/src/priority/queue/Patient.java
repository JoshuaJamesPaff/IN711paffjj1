
package priority.queue;

/**
 *
 * Class for patient - has a name and a priority
 */
public class Patient implements Comparable{
    
    private String name;
    private int priority;
    
    public Patient(String name, int priority){
        this.name = name;
        this.priority = priority;
    }
    
    public int getPriority(){
        return priority;
    }
    
    public String getName(){
        return name;
    }
    
    public String toString(){
        return "name:" + name + ", prioirty: " + priority;
    }


    @Override
    public int compareTo(Object t) {
        Patient p = (Patient) t;
        if(p.priority > priority){
            return 1;
        }else if(p.priority == priority){
            return 0;
        }else{
            return 1;
        }
    }
}
