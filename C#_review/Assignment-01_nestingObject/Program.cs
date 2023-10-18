using Assignment_01_nestingObject;

Laptop laptop = new Laptop("acer",new List<Motherboard>() { new Motherboard(new List<RAM>(){new RAM(new int[] {64,21})},  new List<CPU>(){new CPU(new string[]{"Intel corei3","AMD"})}),
                                                           new Motherboard(new List<RAM>(){new RAM(new int[] {16,48})},new List<CPU>(){new CPU(new string[] {"Intel corei7"})})}
       );


PC pc = new PC("hp", new List<Motherboard>() { new Motherboard(new List<RAM>(){new RAM(new int[] {64,32})},  new List<CPU>(){new CPU(new string[]{"Intel corei5"})}),
                                               new Motherboard(new List<RAM>(){new RAM(new int[] {16,64})},new List<CPU>(){new CPU(new string[] {"Intel corei9"})}),
                                               new Motherboard(new List<RAM>() { new RAM(new int[] { 16, 48 }) }, new List<CPU>() { new CPU(new string[] { "Intel corei7" }) })}
       
       );



SimpleMapper mapper = new SimpleMapper();

mapper.Copy(laptop, pc);
