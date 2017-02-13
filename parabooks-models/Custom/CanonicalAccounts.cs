using System;

namespace com.theparagroup.parabooks.models
{
	public static class CanonicalAccounts
	{

		public static class ASSETS
		{
			public static readonly int Id = 1;

			public static class TANGIBLEASSETS
			{
				public static readonly int Id = 11;

				public static class CURRENTASSETS
				{
					public static readonly int Id = 111;

					public static class CHECKING
					{
						public static readonly int Id = 1111;

					}

					public static class SAVING
					{
						public static readonly int Id = 1112;

					}

					public static class ACCOUNTSRECEIVABLE
					{
						public static readonly int Id = 1113;

					}

					public static class EMPLOYEEADVANCES
					{
						public static readonly int Id = 1114;

					}

					public static class NOTESRECEIVABLECURRENT
					{
						public static readonly int Id = 1115;

					}

					public static class CASH
					{
						public static readonly int Id = 1116;

					}

				}

				public static class FIXEDASSETS
				{
					public static readonly int Id = 112;

				}

				public static class ACCUMULATEDDEPRECIATION
				{
					public static readonly int Id = 113;

					public static class SECTION179ACCUMULATEDDEPRECIATION
					{
						public static readonly int Id = 1131;

					}

				}

				public static class ACCUMULATEDAMORTIZATION
				{
					public static readonly int Id = 114;

				}

				public static class LONGTERMASSETS
				{
					public static readonly int Id = 115;

					public static class NOTESRECEIVABLELONGTERM
					{
						public static readonly int Id = 1151;

					}

				}

				public static class OTHERASSETS
				{
					public static readonly int Id = 116;

				}

			}

			public static class INTANGIBLEASSETS
			{
				public static readonly int Id = 12;

			}

		}

		public static class LIABILITIES
		{
			public static readonly int Id = 2;

			public static class CURRENTLIABILITIES
			{
				public static readonly int Id = 21;

				public static class NOTESPAYABLECURRENT
				{
					public static readonly int Id = 211;

				}

				public static class TAXES
				{
					public static readonly int Id = 212;

					public static class SALESTAXES
					{
						public static readonly int Id = 2121;

					}

					public static class PAYROLLTAXES
					{
						public static readonly int Id = 2122;

						public static class INCOMETAXESWITHHELD
						{
							public static readonly int Id = 21221;

						}

						public static class SOCIALSECURITYWITHHELD
						{
							public static readonly int Id = 21222;

						}

						public static class MEDICAREWITHHELD
						{
							public static readonly int Id = 21223;

						}

						public static class SUTA
						{
							public static readonly int Id = 21224;

						}

						public static class FUTA
						{
							public static readonly int Id = 21225;

						}

					}

				}

				public static class WAGESPAYABLEEXPENSECONTRA
				{
					public static readonly int Id = 90000;

				}

			}

			public static class LONGTERMLIABILITIES
			{
				public static readonly int Id = 22;

				public static class NOTESPAYABLELONGTERM
				{
					public static readonly int Id = 221;

				}

			}

		}

		public static class EQUITY
		{
			public static readonly int Id = 3;

		}

		public static class OPERATINGINCOME
		{
			public static readonly int Id = 4;

			public static class REVENUE
			{
				public static readonly int Id = 41;

			}

		}

		public static class DIRECTCOSTS
		{
			public static readonly int Id = 5;

		}

		public static class OPERATINGEXPENSES
		{
			public static readonly int Id = 6;

			public static class GENERALEXPENSES
			{
				public static readonly int Id = 61;

				public static class PAYROLL
				{
					public static readonly int Id = 611;

					public static class GROSSWAGES
					{
						public static readonly int Id = 6111;

					}

					public static class FRINGEBENEFITS
					{
						public static readonly int Id = 6112;

					}

					public static class WORKERSCOMPENSATION
					{
						public static readonly int Id = 6113;

					}

					public static class SOCIALSECURITYMATCH
					{
						public static readonly int Id = 6114;

					}

					public static class MEDICAREMATCH
					{
						public static readonly int Id = 6115;

					}

					public static class FUTA
					{
						public static readonly int Id = 6116;

					}

					public static class SUTA
					{
						public static readonly int Id = 6117;

					}

				}

				public static class MEALSENTERTAINMENT
				{
					public static readonly int Id = 612;

				}

				public static class OTHEREXPENSES
				{
					public static readonly int Id = 613;

				}

			}

			public static class DEPRECIATIONEXPENSE
			{
				public static readonly int Id = 68;

				public static class SECTION179DEPRECIATIONEXPENSE
				{
					public static readonly int Id = 681;

				}

			}

			public static class AMORTIZATIONEXPENSE
			{
				public static readonly int Id = 69;

			}

		}

		public static class NONOPERATINGINCOME
		{
			public static readonly int Id = 7;

		}

		public static class NONOPERATINGEXPENSES
		{
			public static readonly int Id = 8;

			public static class STARTUPCOSTS
			{
				public static readonly int Id = 89;

			}

		}
	}
}
