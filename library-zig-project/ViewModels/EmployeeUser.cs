using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_zig_project.ViewModels
{
    class EmployeeUser : IUser
    {
        public double amountToBePaid()
        {
            throw new NotImplementedException();
        }

        public AccountType getAccountType()
        {
            throw new NotImplementedException();
        }

        public IBook[] getUserListOfBooksAfterDueDate()
        {
            throw new NotImplementedException();
        }

        public IBook[] getUserListOfBorrowedBooks()
        {
            throw new NotImplementedException();
        }

        public int numberOfBorrowedBooks()
        {
            throw new NotImplementedException();
        }
    }
}
