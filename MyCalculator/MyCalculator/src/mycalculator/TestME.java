package mycalculator;
import junit.framework.*;
import org.junit.Assert;

public class TestME extends TestCase {
    MyCalculator myCalc;

    protected void setUp() {
        myCalc = new MyCalculator();
    }

    public void testSub1() {
        int expectedResult = 2;
        int v = myCalc.add(10, 3);
        v = myCalc.sub(v, 2);
        v = myCalc.sub(v, 11);
        Assert.assertFalse(v = expectedResult);
    }

    public static Test  suite() {
        return new TestSuite(TestME.class);
    }

    public static void main (String[] args) {
        junit.textui.TestRunner.run(suite());
    }
}
