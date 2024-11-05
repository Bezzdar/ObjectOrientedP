using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics.Metrics;


/// <summary>
/// Хранит в себе случайно сгенерированные данные для товаров.
/// </summary>
public static class RandomItemData
{
    /// <summary>
    /// Случайные названия товаров.
    /// </summary>
    public static readonly string[] Names =
    {
        "Беспроводные наушники ARDOR GAMING Temple",
        "Электробритва Timberk T-SHF20L",
        "Портативный аккумулятор Xiaomi Redmi Fast Charge",
        "Настольный светильник Xiaomi Mi Smart LED",
        "Смарт-часы Apple Watch SE 2023",
        "Умная колонка Яндекс.Станция Макс черный",
    };

    /// <summary>
    /// Случайные описания товаров.
    /// </summary>
    public static readonly string[] Info =
    {
        "These high-quality wireless headphones deliver crystal-clear sound and active noise cancellation, ideal for travel, exercise or relaxation. " +
            "Lightweight and comfortable, with a long battery life.",

        "Double wall water bottle that keeps drinks hot for up to 12 hours and cold for up to 24 hours. " +
            "Ideal for hiking, office work or sports.",

        "This powerful 20,000mAh portable battery allows you to quickly charge your device wherever you are. " +
            "Compact and lightweight, perfect for travel.",

        "A dimmable desk lamp with a modern design. " +
            "Its soft lighting creates a cozy atmosphere for working, studying or reading.",

        "Smartwatch with activity tracking, sleep monitoring and smartphone notifications. " +
            "Waterproof and suitable for all types of training.",

        "A wireless speaker with powerful sound and long battery life. " +
            "Its compact design makes it convenient for use at home or outdoors.",
    };

    /// <summary>
    /// Случайные стоимости товаров.
    /// </summary>
    public static readonly double[] Costs =
    {
        36,
        150,
        5144,
        5841,
        20000,
        5191,
        1085,
        969,
        6698,
        5772,
    };
}