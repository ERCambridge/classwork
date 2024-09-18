using Day_7_Unit_Testing;
using System.Diagnostics.Metrics;
using System.Transactions;

namespace CheckingAccountTests
{
    public class CheckingAccountTests
    {
/*          Generate Unit testis for "Happy Path" and "Edge/Error" cases
 * 
 * 
 * 
         * Examples:  An account has a balance of 0 and attempts a withdrawal of $90
 *            ALLOWED as the balance after the transaction would be -100 (with overdraft fee)
 *
 *            An account has a balance of 0 and attempts a withdrawal of $100
 *            NOT ALLOWED as the balance after the transaction would be -110 (with overdraft fee)
 * 
 *            An account has a balance of 100 and attempts a withdrawal of $100
 *            ALLOWED as the balance after the transaction would be 0 */
        [Fact]
        public void Withdrawl_With_Overdraft_Fee()
        {

            //Arrange
            string testAccountOwner = "TestAccount1";
            double testAccountBalance = 0;
            double withdrawalAmmount = 90;

            CheckingAccount testAccount1 = new CheckingAccount(testAccountOwner,testAccountBalance);

            //Act
            testAccount1.Withdraw(withdrawalAmmount);

            //Assert
            Assert.Equal(-100, testAccount1.Balance);
        }
    }
}