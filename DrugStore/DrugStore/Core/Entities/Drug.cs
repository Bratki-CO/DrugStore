namespace DrugStore.Core.Entities;


public class Drug
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Состав 
    /// </summary>
    public string? Info { get; private set; }

    /// <summary>
    /// Тип лекарства
    /// </summary>
    public MedicineType Type { get; private set; }

    /// <summary>
    /// Изготавливаемое ли лекарство
    /// </summary>
    public bool IsManufactured { get; private set; }
}