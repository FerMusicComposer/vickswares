using ViksWares.Models;

namespace ViksWares.Application.Abstractions;

public interface IValueUpdater
{
    void UpdateValue(Item item);
}