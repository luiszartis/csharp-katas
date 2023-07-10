using System.ComponentModel;

namespace WebAPIClient.Model;

public enum SampleEnumType
{
    [Description("Information")]
    Information = 1,

    [Description("Demo")]
    Demo = 2,

    [Description("Free Trial")]
    FreeTrial = 3,
}

public class SampleEnum
{
    public SampleEnumType Id { get; set; }

    public string Value { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public static implicit operator SampleEnumType(SampleEnum sampleEnum) => sampleEnum.Id;

    public IEnumerable<SampleEnum> GetValues()
    {
        var samples = Enum.GetValues(typeof(SampleEnumType));

        foreach (SampleEnumType sample in samples)
        {
            yield return new SampleEnum { Value = sample.GetHashCode().ToString(), Id = sample, Name = GetEnumDescription(sample) };
        }
    }

    private string GetEnumDescription(Enum enumValue)
    {
        var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

        if (fieldInfo == null)
        {
            return string.Empty;
        }

        var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
    }
}
