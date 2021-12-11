import { EtherscanProvider } from "@ethersproject/providers";
import { getContractFactory } from "@nomiclabs/hardhat-ethers/types";
import { expect } from "chai";
import { deployContract } from "ethereum-waffle";
import { ethers,artifacts, hardhatArguments, deployments } from "hardhat";
const IterableMapping = artifacts.readArtifact("IterableMapping");

describe("Greeter", function () {
  it("Should return the new greeting once it's changed", async function () {
    this.timeout(0);
    
    const [first,second,third,fourth] = await ethers.getSigners();

    const test = await deployments.deploy("IterableMapping",{
      from: first.address,
      log: true
    });
    console.log(test.address);
    await new Promise(resolve => setTimeout(resolve, 5000));
    

    const Dividend = await ethers.getContractFactory("DividendPayingToken");
    const dividend = await Dividend.deploy();
    await dividend.deployed();

    const Tracker = await ethers.getContractFactory("BABYTOKENDividendTracker",{
      libraries: {
        IterableMapping: test.address
      }
    });
    const tracker = await Tracker.deploy();
    await tracker.deployed();
    
    const Greeter = await ethers.getContractFactory("BABYTOKEN");
    const greeter = await Greeter.deploy("NIGGER","NIG",100000,
    [dividend.address,"0xD99D1c33F9fC3444f8101754aBC46c52416550D1",third.address,tracker.address],[1,2,3],1,first.address,1);
    await greeter.deployed();
    console.log(greeter.address);

    await tracker.initialize(dividend.address,500);
    await greeter.balanceOf(first.address);
  });
});
