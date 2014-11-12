namespace BestBuyCoinJar
{
    /// <summary>
    /// Interface ICoinValueConvector
    /// </summary>
    interface ICoinValueConvector
    {
       /// <summary>
       /// Convert Rate from other money unit to cent
       /// </summary>
        double ConvertRate { get; }
        
        /// <summary>
        /// Convert from other money unit to cent
        /// </summary>
        /// <param name="valueInOtherUnit">A <see cref="double"/> type representing a value in other money unit.</param>
        /// <returns>A <see cref="double"/> type representing a value in cent.</returns>
        double ConvertToCent(double valueInOtherUnit);

        /// <summary>
        /// Convert from cent to other money unit
        /// </summary>
        /// <param name="valueInCent">A <see cref="double"/> type representing a value in cent.</param>
        /// <returns>A <see cref="double"/> type representing a value in other money unit.</returns>
        double ConvertFromCent(double valueInCent);
    }
}
