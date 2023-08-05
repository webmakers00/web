<template>
	<view class="container">
		<scroll-view scroll-x="true"  class="ctab" >
			<view v-for="(item,index) in dtab" :key="index"  @tap='tabclick(index)' class="ctabidx">
				<!-- <text>{{item.name}}</text> -->
				<text :class='tabidx===index ? "f-active-color" : "f-color"'>{{item.name}}</text>
			</view>
		</scroll-view>		
		<swiper  :indicator-dots="true" :autoplay="false" :interval="3000" :duration="1000"  @change="tabchange" :current="tabidx">
			<swiper-item v-for="(item,index) in dtab" :key="index" >
				<view class="swiper-item">
					{{item.name}}
				</view>
			</swiper-item>
			
		</swiper>
		<!-- <uni-swiper-dot :info="" :current="" field="" :mode=""></uni-swiper-dot>
		<switch checked="true" @change="" /> -->
		
		
		<!-- <view class="intro">本项目已包含uni ui组件，无需import和注册，可直接使用。在代码区键入字母u，即可通过代码助手列出所有可用组件。光标置于组件名称处按F1，即可查看组件文档。</view>
		<text class="intro">详见：</text>
		 <uni-link :href="href" :text="href"></uni-link> -->
	</view>
</template>

<script>
	import $http from "../../api/myrequest.js";
	
	export default {
		data() {
			return {
				href: 'https://uniapp.dcloud.io/component/README?id=uniui',
				tabidx:0,
				dtab:[
					{name:"进度概略"},
					{name:"客户查询"},
					{name:"单号查询"},
					{name:"型号查询"},
					{name:"信息录入"},
					{name:"订单修改"}
					
				]
			}
		},
		onLoad() {
			this._init()
		},
		methods: {
        _init(){
		  console.log($http.c);	
		},
		tabclick(index){
			if (index===this.tabidx) {	return;}
			this.tabidx=index;
			console.log(this.tabidx);
		},
		tabchange(e){
			this.tabidx=e.detail.current;
			console.log(e.detail.current);
			console.log(e.detail.current+100);
		}
		}
	}
</script>

<style>
	.container1 {
		padding: 20px;
		font-size: 14px;
		line-height: 24px;
	}
    .ctab{
		width: 100%;
		height: 80rpm;
		white-space: nowrap;
	}
	.ctabidx{
		display: inline-block;
		padding: 10rpx 20rpx;
	}
</style>
