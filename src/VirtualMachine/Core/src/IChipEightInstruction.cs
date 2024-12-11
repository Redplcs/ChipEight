namespace Redplcs.ChipEight.VirtualMachine.Core;

public interface IChipEightInstruction
{
	ChipEightMnemonic Mnemonic { get; }
}

public interface IChipEightAddressInstruction : IChipEightInstruction
{
	int Address { get; }
}
