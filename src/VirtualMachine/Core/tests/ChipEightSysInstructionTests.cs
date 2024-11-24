namespace Redplcs.ChipEight.VirtualMachine.Core.Tests;

public class ChipEightSysInstructionTests
{
	[Fact]
	public void ChipEightSysInstruction_Always_MnemonicIsSys()
	{
		var mnemonic = ChipEightMnemonic.Sys;
		var instruction = new ChipEightSysInstruction();

		Assert.Equal(mnemonic, instruction.Mnemonic);
	}
}
