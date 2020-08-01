using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Taximeter
{
    public class CDate : Calendar
    {
        public struct DateRow
        {
            public int da_day,
                da_mon,
                da_year;
        };
        /// <summary>
        /// Represents the current era.
        /// </summary>
        /// <remarks>The Persian calendar recognizes one era: A.P. (Latin "Anno Persarum", which means "the year of/for Persians").</remarks>
        public static readonly int PersianEra = 1;
        private string strDay;
        private string strMonth;

        /// <summary>
        /// Returns a DateTime that is the specified number of months away from the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to add.</param>
        /// <param name="months">The number of months to add.</param>
        /// <returns>The DateTime that results from adding the specified number of months to the specified DateTime.</returns>
        /// <remarks>
        /// The year part of the resulting DateTime is affected if the resulting month is beyond the last month of the current year. The day part of the resulting DateTime is also affected if the resulting day is not a valid day in the resulting month of the resulting year; it is changed to the last valid day in the resulting month of the resulting year. The time-of-day part of the resulting DateTime remains the same as the specified DateTime.
        /// 
        /// For example, if the specified month is Ordibehesht, which is the 2nd month and has 31 days, the specified day is the 31th day of that month, and the value of the months parameter is -3, the resulting year is one less than the specified year, the resulting month is Bahman, and the resulting day is the 30th day, which is the last day in Bahman.
        /// 
        /// If the value of the months parameter is negative, the resulting DateTime would be earlier than the specified DateTime.
        /// </remarks>
        public override System.DateTime AddMonths(System.DateTime time, int months)
        {
            if (Math.Abs(months) > 120000)
            {
                throw new Exception("error");
            }
            int year = GetYear(true, time);
            int month = GetMonth(false, time);
            int day = GetDayOfMonth(false, time);

            month += (year - 1) * 12 + months;
            year = (month - 1) / 12 + 1;
            month -= (year - 1) * 12;
            if (day > 29)
            {
                int maxday = GetDaysInMonth(false, year, month, 0);
                if (maxday < day) day = maxday;
            }
            DateTime dateTime;
            try
            {
                dateTime = ToDateTime(year, month, day, 0, 0, 0, 0) + time.TimeOfDay;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                throw new Exception("Error");
            }
            return dateTime;
        }

        /// <summary>
        /// Returns a DateTime that is the specified number of years away from the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to add.</param>
        /// <param name="years">The number of years to add.</param>
        /// <returns>The DateTime that results from adding the specified number of years to the specified DateTime.</returns>
        /// <remarks>
        /// The day part of the resulting DateTime is affected if the resulting day is not a valid day in the resulting month of the resulting year; it is changed to the last valid day in the resulting month of the resulting year. The time-of-day part of the resulting DateTime remains the same as the specified DateTime.
        /// 
        /// For example, Esfand has 29 days, except during leap years when it has 30 days. If the specified date is the 30th day of Esfand in a leap year and the value of years is 1, the resulting date will be the 29th day of Esfand in the following year.
        /// 
        /// If years is negative, the resulting DateTime would be earlier than the specified DateTime.
        /// </remarks>
        public override System.DateTime AddYears(System.DateTime time, int years)
        {
            int year = GetYear(true, time);
            int month = GetMonth(false, time);
            int day = GetDayOfMonth(false, time);
            year += years;
            if (day == 30 && month == 12)
            {
                if (!IsLeapYear(false, year, 0))
                    day = 29;
            }
            DateTime dateTime;
            try
            {
                dateTime = ToDateTime(year, month, day, 0, 0, 0, 0) + time.TimeOfDay;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                throw new Exception("Error");
            }
            return dateTime;
        }

        /// <summary>
        /// Gets the day of the month in the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to read.</param>
        /// <returns>An integer from 1 to 31 that represents the day of the month in time.</returns>
        public override int GetDayOfMonth(System.DateTime time)
        {
            return GetDayOfMonth(true, time);
        }

        private int GetDayOfMonth(bool validate, System.DateTime time)
        {
            int days = GetDayOfYear(validate, time);
            for (int i = 0; i < 6; i++)
            {
                if (days <= 31) return days;
                days -= 31;
            }
            for (int i = 0; i < 5; i++)
            {
                if (days <= 30) return days;
                days -= 30;
            }
            return days;
        }

        /// <summary>
        /// Gets the day of the week in the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to read.</param>
        /// <returns>A DayOfWeek value that represents the day of the week in time.</returns>
        /// <remarks>The DayOfWeek values are Sunday which indicates YekShanbe', Monday which indicates DoShanbe', Tuesday which indicates SeShanbe', Wednesday which indicates ChaharShanbe', Thursday which indicates PanjShanbe', Friday which indicates Jom'e, and Saturday which indicates Shanbe'.</remarks>
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time)
        {
            return time.DayOfWeek;
        }

        public string GetNameOfDay(System.DateTime time, out int nIndex)
        {
            DayOfWeek nDay;

            nDay = time.DayOfWeek;
            nIndex = 0;
            switch (nDay)
            {
                case DayOfWeek.Saturday:
                    strDay = "����";
                    nIndex = 0;
                    break;

                case DayOfWeek.Sunday:
                    strDay = "� ����";
                    nIndex = 1;
                    break;

                case DayOfWeek.Monday:
                    strDay = "������";
                    nIndex = 2;
                    break;

                case DayOfWeek.Tuesday:
                    strDay = "�� ����";
                    nIndex = 3;
                    break;

                case DayOfWeek.Wednesday:
                    strDay = "��������";
                    nIndex = 4;
                    break;

                case DayOfWeek.Thursday:
                    strDay = "��� ����";
                    nIndex = 5;
                    break;

                case DayOfWeek.Friday:
                    strDay = "����";
                    nIndex = 6;
                    break;
            };

            return strDay; ;
        }

        public string GetNameOfMonth(System.DateTime time)
        {
            int nMonth;

            nMonth = GetMonth(time);
            switch (nMonth)
            {
                case 1:
                    strMonth = "�������";
                    break;

                case 2:
                    strMonth = "��������";
                    break;

                case 3:
                    strMonth = "�����";
                    break;

                case 4:
                    strMonth = "����";
                    break;

                case 5:
                    strMonth = "�����";
                    break;

                case 6:
                    strMonth = "������";
                    break;

                case 7:
                    strMonth = "�����";
                    break;

                case 8:
                    strMonth = "������";
                    break;

                case 9:
                    strMonth = "���";
                    break;

                case 10:
                    strMonth = "��";
                    break;

                case 11:
                    strMonth = "�����";
                    break;

                case 12:
                    strMonth = "������";
                    break;
            };

            return strMonth; ;
        }

        /// <summary>
        /// Gets the day of the year in the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to read.</param>
        /// <returns>An integer from 1 to 366 that represents the day of the year in time.</returns>
        public override int GetDayOfYear(System.DateTime time)
        {
            return GetDayOfYear(true, time);
        }

        private int GetDayOfYear(bool validate, System.DateTime time)
        {
            int year;
            int days;
            GetYearAndRemainingDays(validate, time, out year, out days);
            return days;
        }

        /// <summary>
        /// Gets the number of days in the specified month.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="month">An integer that represents the month.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>The number of days in the specified month in the specified year in the specified era.</returns>
        /// <remarks>For example, this method might return 29 or 30 for Esfand (month = 12), depending on whether year is a leap year.</remarks>
        public override int GetDaysInMonth(int year, int month, int era)
        {
            return GetDaysInMonth(true, year, month, era);
        }

        private int GetDaysInMonth(bool validate, int year, int month, int era)
        {
            CheckEraRange(validate, era);
            CheckYearRange(validate, year);
            CheckMonthRange(validate, month);
            if (month < 7) return 31;
            if (month < 12) return 30;
            if (IsLeapYear(false, year, 0)) return 30;
            else return 29;
        }

        /// <summary>
        /// Gets the number of days in the year specified by the year and era parameters.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>The number of days in the specified year in the specified era.</returns>
        /// <remarks>For example, this method might return 365 or 366, depending on whether year is a leap year.</remarks>
        public override int GetDaysInYear(int year, int era)
        {
            return GetDaysInYear(true, year, era);
        }

        private int GetDaysInYear(bool validate, int year, int era)
        {
            if (IsLeapYear(validate, year, era)) return 366;
            return 365;
        }

        /// <summary>
        /// Gets the era in the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to read.</param>
        /// <returns>An integer that represents the era in time.</returns>
        /// <remarks>The Persian calendar recognizes one era: A.P. (Latin "Anno Persarum", which means "the year of/for Persians").</remarks>
        public override int GetEra(System.DateTime time)
        {
            CheckTicksRange(true, time);
            return CDate.PersianEra;
        }

        /// <summary>
        /// Gets the month in the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to read.</param>
        /// <returns>An integer between 1 and 12 that represents the month in time.</returns>
        /// <remarks>Month 1 indicates Farvardin, month 2 indicates Ordibehesht, month 3 indicates Khordad, month 4 indicates Tir, month 5 indicates Amordad, month 6 indicates Shahrivar, month 7 indicates Mehr, month 8 indicates Aban, month 9 indicates Azar, month 10 indicates Dey, month 11 indicates Bahman, and month 12 indicates Esfand.</remarks>
        public override int GetMonth(System.DateTime time)
        {
            return GetMonth(true, time);
        }

        private int GetMonth(bool validate, System.DateTime time)
        {
            int days = GetDayOfYear(validate, time);
            if (days <= 31) return 1;
            if (days <= 62) return 2;
            if (days <= 93) return 3;
            if (days <= 124) return 4;
            if (days <= 155) return 5;
            if (days <= 186) return 6;
            if (days <= 216) return 7;
            if (days <= 246) return 8;
            if (days <= 276) return 9;
            if (days <= 306) return 10;
            if (days <= 336) return 11;
            return 12;
        }

        /// <summary>
        /// Gets the number of months in the year specified by the year and era parameters.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>The number of months in the specified year in the specified era.</returns>
        public override int GetMonthsInYear(int year, int era)
        {
            CheckEraRange(true, era);
            CheckYearRange(true, year);
            return 12;
        }

        /// <summary>
        /// Gets the year in the specified DateTime.
        /// </summary>
        /// <param name="time">The DateTime instance to read.</param>
        /// <returns>An integer between 1 and 9378 that represents the year in time.</returns>
        public override int GetYear(System.DateTime time)
        {
            return GetYear(true, time);
        }

        private int GetYear(bool validate, System.DateTime time)
        {
            int days;
            int year;
            GetYearAndRemainingDays(validate, time, out year, out days);
            return year;
        }

        /// <summary>
        /// Determines whether the date specified by the year, month, day, and era parameters is a leap day.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="month">An integer that represents the month.</param>
        /// <param name="day">An integer that represents the day.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>true if the specified day is a leap day; otherwise, false.</returns>
        /// <remarks>
        /// In the Persian calendar leap years are applied every 4 or 5 years according to a certain pattern that iterates in a 2820-year cycle. A common year has 365 days and a leap year has 366 days.
        /// 
        /// A leap day is a day that occurs only in a leap year. In the Persian calendar, the 30th day of Esfand (month 12) is the only leap day.
        /// </remarks>
        public override bool IsLeapDay(int year, int month, int day, int era)
        {
            CheckEraRange(true, era);
            CheckYearRange(true, year);
            CheckMonthRange(true, month);
            if (day == 30 && month == 12 && IsLeapYear(false, year, 0))
                return true;
            return false;
        }

        /// <summary>
        /// Determines whether the month specified by the year, month, and era parameters is a leap month.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="month">An integer that represents the month.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>This method always returns false, unless overridden by a derived class.</returns>
        /// <remarks>
        /// In the Persian calendar leap years are applied every 4 or 5 years according to a certain pattern that iterates in a 2820-year cycle. A common year has 365 days and a leap year has 366 days.
        /// 
        /// A leap month is an entire month that occurs only in a leap year. The Persian calendar does not have any leap months.
        /// </remarks>
        public override bool IsLeapMonth(int year, int month, int era)
        {
            CheckEraRange(true, era);
            CheckYearRange(true, year);
            CheckMonthRange(true, month);
            return false;
        }

        //  if HasLeapFrac(year)==true and HasLeapFrac(year-1)==false
        //  then 'year' is a leap year.
        private static bool HasLeapFrac(int year)
        {
            double a = 31 * ((double)year + 38) / 128;
            if (a - Math.Floor(a) < 0.31)
                return true;
            return false;
        }

        /// <summary>
        /// Determines whether the year specified by the year and era parameters is a leap year.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>true if the specified year is a leap year; otherwise, false.</returns>
        /// <remarks>In the Persian calendar leap years are applied every 4 or 5 years according to a certain pattern that iterates in a 2820-year cycle. A common year has 365 days and a leap year has 366 days.</remarks>
        public override bool IsLeapYear(int year, int era)
        {
            return IsLeapYear(true, year, era);
        }

        private bool IsLeapYear(bool validate, int year, int era)
        {
            CheckEraRange(validate, era);
            CheckYearRange(validate, year);
            if (HasLeapFrac(year) && !HasLeapFrac(year - 1))
                return true;
            return false;
        }

        /// <summary>
        /// Returns a DateTime that is set to the specified date and time in the specified era.
        /// </summary>
        /// <param name="year">An integer that represents the year.</param>
        /// <param name="month">An integer that represents the month.</param>
        /// <param name="day">An integer that represents the day.</param>
        /// <param name="hour">An integer that represents the hour.</param>
        /// <param name="minute">An integer that represents the minute.</param>
        /// <param name="second">An integer that represents the second.</param>
        /// <param name="millisecond">An integer that represents the millisecond.</param>
        /// <param name="era">An integer that represents the era.</param>
        /// <returns>The DateTime instance set to the specified date and time in the current era.</returns>
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
            CheckEraRange(true, era);
            CheckDateRange(true, year, month, day);
            int days = day;
            for (int i = 1; i < month; i++)
            {
                if (i < 7) days += 31;
                else if (i < 12) days += 30;
            }
            days += 365 * year + NumberOfLeapYearsUntil(false, year);
            // following line validates the arguments of time
            DateTime timePart = new DateTime(1, 1, 1, hour, minute, second, millisecond);
            long ticks = days * 864000000000L + timePart.Ticks + 195721056000000000L;
            DateTime dateTime;
            try
            {
                dateTime = new DateTime(ticks);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                // If ticks go greater than DateTime.MaxValue.Ticks, this exception will be caught
                throw new Exception("Error");
            }
            return dateTime;
        }

        /// <summary>
        /// Converts the specified two-digit year to a four-digit year by using the Globalization.CDate.TwoDigitYearMax property to determine the appropriate century.
        /// </summary>
        /// <param name="year">A two-digit integer that represents the year to convert.</param>
        /// <returns>An integer that contains the four-digit representation of year.</returns>
        /// <remarks>TwoDigitYearMax is the last year in the 100-year range that can be represented by a two-digit year. The century is determined by finding the sole occurrence of the two-digit year within that 100-year range. For example, if TwoDigitYearMax is set to 1429, the 100-year range is from 1330 to 1429; therefore, a 2-digit value of 30 is interpreted as 1330, while a 2-digit value of 29 is interpreted as 1429.</remarks>
        public override int ToFourDigitYear(int year)
        {
            if (year != 0)
            {
                try
                {
                    CheckYearRange(true, year);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    throw new Exception("Error");
                }
            }
            if (year > 99) return year;
            int a = TwoDigitYearMax / 100;
            if (year > TwoDigitYearMax - a * 100) a--;
            return a * 100 + year;
        }

        /// <summary>
        /// Gets the list of eras in the CDate.
        /// </summary>
        /// <remarks>The Persian calendar recognizes one era: A.P. (Latin "Anno Persarum", which means "the year of/for Persians").</remarks>
        public override int[] Eras
        {
            get
            {
                int[] eras = { 1 };
                return eras;
            }
        }

        private int twoDigitYearMax = 1409;

        /// <summary>
        /// Gets and sets the last year of a 100-year range that can be represented by a 2-digit year.
        /// </summary>
        /// <property_value>The last year of a 100-year range that can be represented by a 2-digit year.</property_value>
        /// <remarks>This property allows a 2-digit year to be properly translated to a 4-digit year. For example, if this property is set to 1429, the 100-year range is from 1330 to 1429; therefore, a 2-digit value of 30 is interpreted as 1330, while a 2-digit value of 29 is interpreted as 1429.</remarks>
        public new int TwoDigitYearMax
        {
            get
            {
                return twoDigitYearMax;
            }
            set
            {
                if (value < 100 || 9378 < value)
                    throw new Exception("Error");
                twoDigitYearMax = value;
            }
        }

        /// <summary>
        /// Gets the century of the specified DateTime.
        /// </summary>
        /// <param name="time">An instance of the DateTime class to read.</param>
        /// <returns>An integer from 1 to 94 that represents the century.</returns>
        /// <remarks>A century is a whole 100-year period. So the century 14 for example, represents years 1301 through 1400.</remarks>
        public int GetCentury(System.DateTime time)
        {
            return (GetYear(true, time) - 1) / 100 + 1;
        }

        /// <summary>
        /// Calculates the number of leap years until -but not including- the specified year.
        /// </summary>
        /// <param name="year">An integer between 1 and 9378</param>
        /// <returns>An integer representing the number of leap years that have occured by the year specified.</returns>
        /// <remarks>In the Persian calendar leap years are applied every 4 or 5 years according to a certain pattern that iterates in a 2820-year cycle. A common year has 365 days and a leap year has 366 days.</remarks>
        public int NumberOfLeapYearsUntil(int year)
        {
            return NumberOfLeapYearsUntil(true, year);
        }

        private int NumberOfLeapYearsUntil(bool validate, int year)
        {
            CheckYearRange(validate, year);
            int count = 0;
            for (int i = 4; i < year; i++)
            {
                if (IsLeapYear(false, i, 0))
                {
                    count++;
                    i += 3;
                }
            }
            return count;
        }

        private void CheckEraRange(bool validate, int era)
        {
            if (validate)
            {
                if (era < 0 || 1 < era)
                    throw new Exception("Error");
            }
            return;
        }

        private void CheckYearRange(bool validate, int year)
        {
            if (validate)
            {
                if (year < 1 || 9378 < year)
                    throw new Exception("Error");
            }
            return;
        }

        private void CheckMonthRange(bool validate, int month)
        {
            if (validate)
            {
                if (month < 1 || 12 < month)
                    throw new Exception("Error");
            }
            return;
        }

        private void CheckDateRange(bool validate, int year, int month, int day)
        {
            if (validate)
            {
                int maxday = GetDaysInMonth(true, year, month, 0);
                if (day < 1 || maxday < day)
                {
                    if (day == 30 && month == 12)
                        throw new Exception("Error");
                    throw new Exception("Error");
                }
            }
        }

        private void CheckTicksRange(bool validate, DateTime time)
        {
            // Valid ticks represent times between 12:00:00.000 AM, 22/03/0622 CE and 11:59:59.999 PM, 31/12/9999 CE.
            if (validate)
            {
                long ticks = time.Ticks;
                if (ticks < 196037280000000000L)
                    throw new Exception("Error");
            }
            return;
        }

        private void GetYearAndRemainingDays(bool validate, DateTime time, out int year, out int days)
        {
            CheckTicksRange(validate, time);
            days = (time - new DateTime(196036416000000000L)).Days;
            year = 1;
            int daysInNextYear = 365;
            while (days > daysInNextYear)
            {
                days -= daysInNextYear;
                year++;
                daysInNextYear = GetDaysInYear(false, year, 0);
            }
            return;
        }

        public string GetPersianDate(DateTime time, bool WithSlash)
        {
            string strDate,
                strYear,
                strMonth,
                strDay;

            strYear = GetYear(time).ToString();
            strMonth = GetMonth(time).ToString();
            strDay = GetDayOfMonth(time).ToString();

            if (strYear.Length < 4)
                strYear = "13" + strYear;

            if (strMonth.Length < 2)
                strMonth = "0" + strMonth;

            if (strDay.Length < 2)
                strDay = "0" + strDay;

            if (WithSlash)
                strDate = strYear + "/" + strMonth + "/" + strDay;
            else
                strDate = strYear + strMonth + strDay;

            return strDate;
        }

        public string GetPersianDate(string strDate, bool InputWithSladh, bool OutputWithSlash)
        {
            int nYear, nMonth, nDay;
            DateTime ocTempDate;

            try
            {
                // Date string validateing
                if (InputWithSladh)
                {
                    if (strDate.Length != 10)
                        throw new Exception("Error");

                    nYear = Convert.ToInt32(strDate.Substring(0, 4));
                    nMonth = Convert.ToInt32(strDate.Substring(5, 2));
                    nDay = Convert.ToInt32(strDate.Substring(8, 2));
                }
                else
                {
                    if (strDate.Length != 8)
                        throw new Exception("Error");

                    nYear = Convert.ToInt32(strDate.Substring(0, 4));
                    nMonth = Convert.ToInt32(strDate.Substring(4, 2));
                    nDay = Convert.ToInt32(strDate.Substring(6, 2));
                }

                ocTempDate = new DateTime(nYear, nMonth, nDay);
                return GetPersianDate(ocTempDate, OutputWithSlash);
            }
            catch (Exception ocException)
            {
                throw new Exception("Error");
            }
        }

        public string GetMiladiDate(int Year, int Month, int Day, bool OutputWithSlash)
        {
            int[] Conm_mons = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] LeapYearSh = { 1299, 1303, 1307, 1311, 1315, 1319, 1323, 1327, 1331, 1335, 1339, 1343, 1347, 1351, 1355, 1359, 1363, 1367, 1371, 1375, 1379, 1383, 1387, 1391 };
            int[] LeapYearMi = { 1920, 1924, 1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980, 1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012 };

            int[] m_mons = new int[12];
            int LastDayCountSh, LastDayCountMi;

            DateRow a, b;

            string sYY = string.Empty, sMM = string.Empty, sDD = string.Empty;
            int nIdx;

            for (nIdx = 0; nIdx < 12; nIdx++)
                m_mons[nIdx] = Conm_mons[nIdx];

            a.da_day = Day;
            a.da_mon = Month;
            a.da_year = Year;

            b.da_year = a.da_year + 621;

            Inc(ref b.da_year, TrueTo1(((a.da_mon > 10) || ((a.da_mon == 10) && (a.da_day >= 12))) || ((LeapYearSh[(a.da_year - 1299) / 4] != a.da_year) && ((a.da_mon == 10) && (a.da_day == 11)))));
            Inc(ref m_mons[0], TrueTo1(LeapYearMi[(b.da_year - 1920) / 4] == b.da_year));

            if (a.da_mon <= 7)
                LastDayCountSh = ((a.da_mon - 1) * 31 + a.da_day);
            else
                LastDayCountSh = (186 + (a.da_mon - 7) * 30 + a.da_day);

            if (b.da_year == (a.da_year + 622))
                LastDayCountMi = LastDayCountSh - 286 - TrueTo1(LeapYearSh[(a.da_year - 1299) / 4] == a.da_year);
            else
                LastDayCountMi = (LastDayCountSh + 79);

            b.da_day = LastDayCountMi;
            b.da_mon = 0;
            while (LastDayCountMi > m_mons[b.da_mon])
            {
                Dec(ref LastDayCountMi, m_mons[b.da_mon]);
                Inc(ref b.da_mon);
                b.da_day = LastDayCountMi;
            };

            Inc(ref b.da_mon);
            if (b.da_year < 1000) sYY = sYY + '0';
            if (b.da_year < 100) sYY = sYY + '0';
            if (b.da_year < 10) sYY = sYY + '0';

            sYY = sYY + (b.da_year).ToString();

            if (b.da_mon < 10) sMM = sMM + '0';
            sMM = sMM + (b.da_mon).ToString();

            if (b.da_day < 10) sDD = sDD + '0';
            sDD = sDD + (b.da_day).ToString();

            if (OutputWithSlash)
                return sYY + '/' + sMM + '/' + sDD;
            else
                return sYY + sMM + sDD;
        }

        public string GetMiladiDate(string strDate, bool InputWithSladh, bool OutputWithSlash)
        {
            int Day, Month, Year;

            // Date string validateing
            if (InputWithSladh)
            {
                if (strDate.Length != 10)
                    throw new Exception("Error");

                Year = Convert.ToInt32(strDate.Substring(0, 4));
                Month = Convert.ToInt32(strDate.Substring(5, 2));
                Day = Convert.ToInt32(strDate.Substring(8, 2));
                return GetMiladiDate(Year, Month, Day, OutputWithSlash);
            }
            else
            {
                if (strDate.Length != 8)
                    throw new Exception("Error");

                Year = Convert.ToInt32(strDate.Substring(0, 4));
                Month = Convert.ToInt32(strDate.Substring(4, 2));
                Day = Convert.ToInt32(strDate.Substring(6, 2));

                return GetMiladiDate(Year, Month, Day, OutputWithSlash);
            }
        }

        private int TrueTo1(bool co)
        {
            if (co) return 1;
            else return 0;
        }

        private void Inc(ref int nInput)
        {
            nInput++;
        }

        private void Inc(ref int nInput, int nValue)
        {
            nInput += nValue;
        }

        private void Dec(ref int nInput)
        {
            nInput--;
        }

        private void Dec(ref int nInput, int nValue)
        {
            nInput -= nValue;
        }
    }
}
