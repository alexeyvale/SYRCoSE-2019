# LanD parser generator
This is the version of LanD parser generator referenced in [the paper](https://www.ispras.ru/proceedings/docs/2019/31/3/isp_31_2019_3_7.pdf) presented at SYRCoSE'19.

This repository was created separately from the repository where the main development takes place and was intended for referencing in the research only. The main repository is [here](https://github.com/alexeyvale/LanD).

## Prerequisites
[Java Runtime Environment](http://www.oracle.com/technetwork/java/javase/downloads/jre8-downloads-2133155.html) must be installed for correct lexical analyzer generation and work.

Missing NuGet packages will be automatically restored when the solution is built for the first time.
## Previous and further research on tolerant parsing and binding to code
* Tolerant parsing with a special kind of «Any» symbol: the algorithm and practical application, **2018** |
_[paper](https://www.ispras.ru/proceedings/docs/2018/30/4/isp_30_2018_4_7.pdf) & [repo](https://github.com/alexeyvale/SYRCoSE-2018)_
  
* Using improved context-based code description for robust algorithmic binding to changing code, **2021** | _[paper](https://www.sciencedirect.com/science/article/pii/S1877050921020652) & [repo](https://github.com/alexeyvale/YSC-2021) (LanD & the Land Explorer tool)_

* Robust algorithmic binding to arbitrary fragment of program code, **2022** | _[paper](https://psta.psiras.ru/read/psta2022_1_35-62.pdf)_
