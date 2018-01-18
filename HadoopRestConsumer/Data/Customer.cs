using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HadoopRestConsumer.Data
{
    public class Customer
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
/*
USE[TokenDatabase]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE[dbo].[Customer]
(

   [Email][varchar](50) NOT NULL,

  [Password] [varchar] (50) NULL,
	[Token] [varchar] (500) NULL,
 CONSTRAINT[PK_Customer] PRIMARY KEY CLUSTERED
(
   [Email] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]

GO

SET ANSI_PADDING OFF
GO

*/
