namespace Redplcs.ChipEight.VirtualMachine.Core;

public readonly struct ChipEightClrInstruction : IChipEightInstruction
{
	public ChipEightMnemonic Mnemonic => ChipEightMnemonic.Clr;
}
