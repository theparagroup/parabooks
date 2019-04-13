using System;

namespace com.theparagroup.parabooks.models
{
	public static class CanonicalAccounts
	{

		public static class ASSETS
		{
			public static readonly long Id = 1;

			public static class TANGIBLEASSETS
			{
				public static readonly long Id = 11;

				public static class CURRENTASSETS
				{
					public static readonly long Id = 111;

					public static class CHECKING
					{
						public static readonly long Id = 1111;

					}

					public static class SAVING
					{
						public static readonly long Id = 1112;

					}

					public static class ACCOUNTSRECEIVABLE
					{
						public static readonly long Id = 1113;

					}

					public static class EMPLOYEEADVANCES
					{
						public static readonly long Id = 1114;

					}

					public static class NOTESRECEIVABLECURRENT
					{
						public static readonly long Id = 1115;

					}

					public static class CASH
					{
						public static readonly long Id = 1116;

					}

				}

				public static class FIXEDASSETS
				{
					public static readonly long Id = 112;

				}

				public static class ACCUMULATEDDEPRECIATION
				{
					public static readonly long Id = 113;

					public static class SECTION179ACCUMULATEDDEPRECIATION
					{
						public static readonly long Id = 1131;

					}

				}

				public static class ACCUMULATEDAMORTIZATION
				{
					public static readonly long Id = 114;

				}

				public static class LONGTERMASSETS
				{
					public static readonly long Id = 115;

					public static class NOTESRECEIVABLELONGTERM
					{
						public static readonly long Id = 1151;

					}

				}

				public static class OTHERASSETS
				{
					public static readonly long Id = 116;

				}

			}

			public static class INTANGIBLEASSETS
			{
				public static readonly long Id = 12;

			}

		}

		public static class LIABILITIES
		{
			public static readonly long Id = 2;

			public static class CURRENTLIABILITIES
			{
				public static readonly long Id = 21;

				public static class NOTESPAYABLECURRENT
				{
					public static readonly long Id = 211;

				}

				public static class TAXES
				{
					public static readonly long Id = 212;

					public static class SALESTAXES
					{
						public static readonly long Id = 2121;

					}

					public static class PAYROLLTAXES
					{
						public static readonly long Id = 2122;

						public static class INCOMETAXESWITHHELD
						{
							public static readonly long Id = 21221;

						}

						public static class SOCIALSECURITYWITHHELD
						{
							public static readonly long Id = 21222;

						}

						public static class MEDICAREWITHHELD
						{
							public static readonly long Id = 21223;

						}

						public static class SUTA
						{
							public static readonly long Id = 21224;

						}

						public static class FUTA
						{
							public static readonly long Id = 21225;

						}

					}

				}

				public static class WAGESPAYABLEEXPENSECONTRA
				{
					public static readonly long Id = 90000;

				}

			}

			public static class LONGTERMLIABILITIES
			{
				public static readonly long Id = 22;

				public static class NOTESPAYABLELONGTERM
				{
					public static readonly long Id = 221;

				}

			}

		}

		public static class EQUITY
		{
			public static readonly long Id = 3;

		}

		public static class OPERATINGINCOME
		{
			public static readonly long Id = 4;

			public static class REVENUE
			{
				public static readonly long Id = 41;

			}

		}

		public static class DIRECTCOSTS
		{
			public static readonly long Id = 5;

		}

		public static class OPERATINGEXPENSES
		{
			public static readonly long Id = 6;

			public static class GENERALEXPENSES
			{
				public static readonly long Id = 61;

				public static class PAYROLL
				{
					public static readonly long Id = 611;

					public static class GROSSWAGES
					{
						public static readonly long Id = 6111;

					}

					public static class FRINGEBENEFITS
					{
						public static readonly long Id = 6112;

					}

					public static class WORKERSCOMPENSATION
					{
						public static readonly long Id = 6113;

					}

					public static class SOCIALSECURITYMATCH
					{
						public static readonly long Id = 6114;

					}

					public static class MEDICAREMATCH
					{
						public static readonly long Id = 6115;

					}

					public static class FUTA
					{
						public static readonly long Id = 6116;

					}

					public static class SUTA
					{
						public static readonly long Id = 6117;

					}

				}

				public static class MEALSENTERTAINMENT
				{
					public static readonly long Id = 612;

				}

				public static class OTHEREXPENSES
				{
					public static readonly long Id = 613;

				}

			}

			public static class DEPRECIATIONEXPENSE
			{
				public static readonly long Id = 68;

				public static class SECTION179DEPRECIATIONEXPENSE
				{
					public static readonly long Id = 681;

				}

			}

			public static class AMORTIZATIONEXPENSE
			{
				public static readonly long Id = 69;

			}

		}

		public static class NONOPERATINGINCOME
		{
			public static readonly long Id = 7;

		}

		public static class NONOPERATINGEXPENSES
		{
			public static readonly long Id = 8;

			public static class STARTUPCOSTS
			{
				public static readonly long Id = 89;

			}

		}
	}
}
