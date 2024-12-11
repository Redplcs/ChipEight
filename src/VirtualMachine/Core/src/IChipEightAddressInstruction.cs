namespace Redplcs.ChipEight.VirtualMachine.Core;

public interface IChipEightAddressInstruction : IChipEightInstruction
{
	int Address { get; }
}
