namespace Redplcs.ChipEight.VirtualMachine.Core;

public readonly struct ChipEightRtsInstruction : IChipEightInstruction
{
	public ChipEightMnemonic Mnemonic => ChipEightMnemonic.Rts;
}
