/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mycalculator;

/**
 *
 * @author kentsang
 */
public class MyCalculator {

    public int add(int v1, int v2) {

        return v1 + v2;
    }
    public int sub(int v1, int v2) {
        return v1 - v2;
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        MyCalculator myCalc = new MyCalculator();
        System.out.println("2 + 3 = " + myCalc.add(2,3));
        System.out.println("9 - 2 = " + myCalc.sub(9,2));
        
    }
 
    
}
