/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpletest;

// JUnit packages
import org.junit.Assert;
import junit.framework.Test;
import junit.framework.TestCase;
import junit.framework.TestSuite;

/**
 *
 * @author kentsang
 */
// JUnit framework extends TestCase 
public class SimpleTest extends TestCase {

// your code to be tested (SUT)
    protected int fValue1;
    protected int fValue2;

    protected static int add(int v1, int v2) {
        return v1 + v2;
    }

// tester
// standard JUnit methods
    // setUp() will be called when EACH test starts
    protected void setUp() {
        fValue1 = 3;
        fValue2 = 3;
    }

    // your test cases 
    public void testAdd() {
        int expectedResult = 5;

        int v = add(2, 3);
        Assert.assertTrue(v == expectedResult); // should be true 
    }

    public void testEquals() {
        Assert.assertEquals(fValue1, fValue2);
        Assert.assertEquals(12, 12);
        Assert.assertEquals(add(3, 7), 10);
    }

    public static Test suite() {
        return new TestSuite(SimpleTest.class);
    }

    public static void main(String[] args) {
        junit.textui.TestRunner.run(suite());
    }

}
