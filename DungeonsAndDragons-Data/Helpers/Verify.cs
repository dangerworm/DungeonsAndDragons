using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons_Data
{
    public static class Verify
    {
        /// <summary>
        /// Verifies the specified parameter instance is not null and throws an <see cref="ArgumentNullException"/> if the instance is null.
        /// </summary>
        /// <param name="parameter">The parameter instance to verify.</param>
        /// <param name="parameterName">The name of the parameter under verification.</param>
        /// <param name="message">An optional message to provide further information if the exception is thrown.</param>
        [ContractAnnotation("halt <= parameter: null")]
        public static void NotNull(object parameter, [InvokerParameterName] string parameterName, string message = null)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(parameterName, message);
            }
        }

        /// <summary>
        /// Verifies that the given string is considered to be valid - i.e. not null or empty (or consisting of only whitespace characters, if
        /// specified) ; and throws an <see cref="ArgumentException"/> if the string is deemed to be invalid.
        /// </summary>
        /// <param name="parameter">The string value to be verified.</param>
        /// <param name="parameterName">The name of the parameter under verification.</param>
        /// <param name="allowWhitespace">Specifies whether the string is still considered valid when it is comprised solely of whitespace characters.
        /// The default is false.</param>
        [ContractAnnotation("halt <= parameter: null")]
        public static void ValidString(string parameter, [InvokerParameterName] string parameterName,
            bool allowWhitespace = false)
        {
            if ((allowWhitespace && string.IsNullOrEmpty(parameter))
                || !allowWhitespace && StringHelper.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentException(parameterName);
            }
        }

        /// <summary>
        /// Verifies that the <paramref name="condition"/> condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="parameterName">The name of the parameter being checked.</param>
        /// <param name="message">An optional exception message for if the <paramref name="condition"/> is false.</param>
        /// <exception cref="ArgumentException">Throw when the <paramref name="condition"/> is false.</exception>
        [ContractAnnotation("halt <= condition: false")]
        public static void IsTrue(bool condition, [InvokerParameterName] string parameterName, string message = null)
        {
            if (!condition)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentException(message, parameterName);
                }

                throw new ArgumentException("The specified condition must be true.", parameterName);
            }
        }

        /// <summary>
        /// Verifies that the <paramref name="condition"/> condition is false.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="parameterName">The name of the parameter being checked.</param>
        /// <param name="message">An optional exception message for if the <paramref name="condition"/> is true.</param>
        /// <exception cref="ArgumentException">Throw when the <paramref name="condition"/> is true.</exception>
        [ContractAnnotation("halt <= condition: true")]
        public static void IsFalse(bool condition, [InvokerParameterName] string parameterName, string message = null)
        {
            if (condition)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentException(message, parameterName);
                }

                throw new ArgumentException("The specified condition must be false.", parameterName);
            }
        }

        /// <summary>
        /// Verifies that an operation is valid by evaluating the specified <paramref name="condition"/>.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="message">An optional exception message for if the <paramref name="condition"/> is false.</param>
        /// <exception cref="InvalidOperationException">Throw when the <paramref name="condition"/> is false.</exception>
        [ContractAnnotation("halt <= condition: false")]
        public static void ValidOperation(bool condition, string message = null)
        {
            if (!condition)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new InvalidOperationException(message);
                }

                throw new InvalidOperationException("The specified condition must be true.");
            }
        }

        /// <summary>
        /// Verifies that the <paramref name="parameter"/> value is greater than a given value.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="parameter"/> value.</typeparam>
        /// <param name="parameter">The value to check.</param>
        /// <param name="parameterName">The name of the <paramref name="parameter"/> beign checked.</param>
        /// <param name="minValue">A value that the <paramref name="parameter"/> must be greater than.</param>
        /// <param name="message">An optional exception message for if the <paramref name="parameter"/> is not greater than <paramref name="minValue"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the <paramref name="parameter"/> value is not greater than the <paramref name="minValue"/>.</exception>
        public static void GreaterThan<T>(T parameter, [InvokerParameterName] string parameterName, T minValue,
            string message = null)
            where T : IComparable<T>
        {
            if (parameter.CompareTo(minValue) <= 0)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentOutOfRangeException(parameterName, message);
                }

                throw new ArgumentOutOfRangeException(parameterName, parameter,
                    string.Format("The specified value must be greater than {0}.", minValue));
            }
        }

        /// <summary>
        /// Verifies that the <paramref name="parameter"/> value is greater than or equal to a given value.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="parameter"/> value.</typeparam>
        /// <param name="parameter">The value to check.</param>
        /// <param name="parameterName">The name of the <paramref name="parameter"/> beign checked.</param>
        /// <param name="minValue">A value that the <paramref name="parameter"/> must be greater than or equal to.</param>
        /// <param name="message">An optional exception message for if the <paramref name="parameter"/> is not greater than or equal to <paramref name="minValue"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the <paramref name="parameter"/> value is not greater than or eqaul to <paramref name="minValue"/>.</exception>
        public static void GreaterThanOrEqualTo<T>(T parameter, [InvokerParameterName] string parameterName, T minValue,
            string message = null)
            where T : IComparable<T>
        {
            if (parameter.CompareTo(minValue) < 0)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentOutOfRangeException(parameterName, message);
                }

                throw new ArgumentOutOfRangeException(parameterName, parameter,
                    string.Format("The specified value must be greater than or equal to {0}.", minValue));
            }
        }

        /// <summary>
        /// Verifies that the <paramref name="parameter"/> value is less than a given value.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="parameter"/> value.</typeparam>
        /// <param name="parameter">The value to check.</param>
        /// <param name="parameterName">The name of the <paramref name="parameter"/> beign checked.</param>
        /// <param name="maxValue">A value that the <paramref name="parameter"/> must be less than.</param>
        /// <param name="message">An optional exception message for if the <paramref name="parameter"/> is not less than <paramref name="maxValue"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the <paramref name="parameter"/> value is not less than the <paramref name="maxValue"/>.</exception>
        public static void LessThan<T>(T parameter, [InvokerParameterName] string parameterName, T maxValue,
            string message = null)
            where T : IComparable<T>
        {
            if (parameter.CompareTo(maxValue) >= 0)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentOutOfRangeException(parameterName, message);
                }

                throw new ArgumentOutOfRangeException(parameterName, parameter,
                    string.Format("The specified value must be less than {0}.", maxValue));
            }
        }

        /// <summary>
        /// Verifies that the <paramref name="parameter"/> value is less than or equal to a given value.
        /// </summary>
        /// <typeparam name="T">The type of the <paramref name="parameter"/> value.</typeparam>
        /// <param name="parameter">The value to check.</param>
        /// <param name="parameterName">The name of the <paramref name="parameter"/> beign checked.</param>
        /// <param name="maxValue">A value that the <paramref name="parameter"/> must be less than.</param>
        /// <param name="message">An optional exception message for if the <paramref name="parameter"/> is not less than <paramref name="maxValue"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the <paramref name="parameter"/> value is not less than the <paramref name="maxValue"/>.</exception>
        public static void LessThanOrEqualTo<T>(T parameter, [InvokerParameterName] string parameterName, T maxValue,
            string message = null)
            where T : IComparable<T>
        {
            if (parameter.CompareTo(maxValue) > 0)
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentOutOfRangeException(parameterName, message);
                }

                throw new ArgumentOutOfRangeException(parameterName, parameter,
                    string.Format("The specified value must be less than or equal to {0}.", maxValue));
            }
        }

        /// <summary>
        /// Verifies that the given value lies within the range between the given minimum and maximum values and throws an
        /// <see cref="ArgumentOutOfRangeException"/> if it does not.
        /// </summary>
        /// <param name="value">The value to check resides within the range.</param>
        /// <param name="minimum">The lower bound of the valid number range.</param>
        /// <param name="maximum">The upper bound of the valid number range.</param>
        /// <param name="parameterName">The name of the parameter under verification.</param>
        public static void InRange(int value, int minimum, int maximum, [InvokerParameterName] string parameterName)
        {
            if (value < minimum || value > maximum)
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }

        /// <summary>
        /// Verifies that the given Enum value is defined within the specified Enum type and throws an <see cref="ArgumentOutOfRangeException"/> if it
        /// is not.
        /// </summary>
        /// <typeparam name="TEnum">The type of Enum to check for a definition within.</typeparam>
        /// <param name="enumValue">The value of the Enum to be verified.</param>
        /// <param name="parameterName">The name of the parameter under verification.</param>
        /// <exception cref="ArgumentException">Thrown when the specified type is not a valid Enum.</exception>
        public static void ValidEnumValue<TEnum>(TEnum enumValue, [InvokerParameterName] string parameterName)
        {
            var enumType = typeof(TEnum);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException(string.Format("The specified type '{0}' is not a valid Enum.",
                    enumType.FullName));
            }

            if (!Enum.IsDefined(enumType, enumValue))
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }
    }
}
