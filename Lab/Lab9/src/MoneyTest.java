public class MoneyTest {
    private Money f12CHF;
    private Money f14CHF;
    private Money f7USD;
    private Money f21USD;

    @BeforeClass
    public static void setUpClass()
    {
        System.out.println("@setUpClass");
    }

    @AfterClass
    public static void tearDownClass()
    {
        System.out.println("@tearDownClass");
    }

    @Before
    public void setUp()
    {
        System.out.println("@setUp");
        f12CHF= new Money(12, "CHF");
        f14CHF= new Money(14, "CHF");
        f7USD= new Money( 7, "USD");
        f21USD= new Money(21, "USD");
    }

    @After
    public void tearDown()
    {
        System.out.println("@tearDown");
    }
    /**
     * Test method for {@link junit.samples.money.Money#add(junit.samples.money.IMoney)}.
     */
    @Test
    public void testAdd()
    {
        System.out.println("@testAdd");
        // check that [12 CHF] + [14 CHF] = [26 CHF]
// with the assertEquals method of Assert class
// to be completed by you!
        Money expected = new Money(26, "CHF");
        Assert.assertEquals(expected, f12CHF.add(f14CHF));

    }

    /**
     * Test method for {@link.junit.samples.money.Money#addMoney(
     *  junit.samples.money.Money)}.
     */
    @Test
    public void testAddMoney()
    {
        System.out.println("@testAddMoney");
        // check that [7 USD] + [21 USD] = [28 USD]
// with the assertEquals method of Assert class
// to be completed by you!

    }
    /**
     * Test method for {@link junit.samples.money.Money#isZero()}.
     */
    @Test
    public void testIsZero()
    {
        System.out.println("@testIsZero");
        // check that [0 USD] is Zero
// with the assertTrue method of Assert class
// to be completed by you!

        // check that [12 USD] is not Zero
// with the assertFalse method of Assert class
// to be completed by you!

    }
    /**
     * Test method for {@link junit.samples.money.Money#multiply(int)}.
     */
    @Test
    public void testMultiply()
    {
        System.out.println("@testMultiply");
        // check that [14 CHF] *2 == [28 CHF]
// with the assertEquals method of Assert class
// to be completed by you!

    }
    /**
     * Test method for {@link junit.samples.money.Money#negate()}.
     */
    @Test
    public void testNegate()
    {
        System.out.println("@testNegate");
        // check that [14 CHF] negate == [-14 CHF]
// with the assertEquals method of Assert class
// to be completed by you!

    }
    /**
     * Test method for {@link junit.samples.money.Money#subtract(junit.samples.money.IMoney)}.
     */
    @Test
    public void testSubtract()
    {
        System.out.println("@testSubtract");
        // check that [14 CHF] - [12 CHF] == [2 CHF]
// with the assertEquals method of Assert class
// to be completed by you!

    }

}
