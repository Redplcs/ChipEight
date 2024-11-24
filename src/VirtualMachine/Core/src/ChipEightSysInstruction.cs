namespace Redplcs.ChipEight.VirtualMachine.Core;

public readonly struct ChipEightSysInstruction : IChipEightInstruction
{
	public readonly ChipEightMnemonic Mnemonic => ChipEightMnemonic.Sys;
}
