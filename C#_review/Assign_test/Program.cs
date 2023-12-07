using Assign_test;

Laptop laptop = new Laptop(102, "acer", new List<Motherboard>() { new Motherboard(new List<RAM>(){new RAM(new int[] {64,21})},  new List<CPU>(){new CPU(new string[]{"Intel corei3","AMD"})}),
                                                           new Motherboard(new List<RAM>(){new RAM(new int[] {16,48})},new List<CPU>(){new CPU(new string[] {"Intel corei7"})})}
       );


PC pc = new PC(101, "acer", new List<Motherboard>() { new Motherboard(new List<RAM>(){new RAM(new int[] {64,32})},  new List<CPU>(){new CPU(new string[]{"Intel corei5","Intel"})}),

                                               new Motherboard(new List<RAM>() { new RAM(new int[] { 16, 48 }) }, new List<CPU>() { new CPU(new string[] { "Intel corei7" }) })}

       );

PC pc1 = new PC(102, null, new List<Motherboard>() { new Motherboard(new List<RAM>(){new RAM(new int[] {64,32})},  new List<CPU>(){new CPU(new string[]{"Intel corei5","Intel"})}),

                            new Motherboard(new List<RAM>() { new RAM(new int[] { 16, 48 }) }, new List<CPU>() { new CPU(new string[] { "Intel corei7" }) })});




SimpleMapper mapper = new SimpleMapper();

mapper.Copy(laptop, pc1);

