class Program {
	static public void Main() {
		int[] Mem = new int[30000]; //Memory cells
		for(int i = 0; i < 30000; i++)
			Mem[i] = 0;
		int Ptr = 0; //Pointer

		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Ptr++;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Ptr++;
		Ptr++;
		Ptr++;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		while(Mem[Ptr] > 0) {
			Ptr++;
			Ptr++;
			Mem[Ptr] = System.Console.Read();
			while(Mem[Ptr] > 0) {
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr--;
				while(Mem[Ptr] > 0) {
					while(Mem[Ptr] > 0) {
						Mem[Ptr] = (Mem[Ptr] - 1) % 256;
						Ptr++;
					}
					Ptr--;
					Ptr--;
				}
				Ptr--;
				while(Mem[Ptr] > 0) {
					Ptr++;
				}
				Ptr++;
			}
			Ptr++;
			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			while(Mem[Ptr] > 0) {
				Ptr--;
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr++;
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				while(Mem[Ptr] > 0) {
					Ptr--;
					Ptr--;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					Ptr++;
					Ptr++;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					while(Mem[Ptr] > 0) {
						Mem[Ptr] = (Mem[Ptr] - 1) % 256;
						Ptr++;
					}
					Ptr--;
				}
			}
			Ptr--;
			while(Mem[Ptr] > 0) {
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				Ptr--;
				while(Mem[Ptr] > 0) {
					Ptr--;
				}
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				while(Mem[Ptr] > 0) {
					Ptr++;
				}
				Ptr--;
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				Ptr++;
				Ptr++;
				Ptr++;
			}
			Ptr--;
		}
		Ptr--;
		while(Mem[Ptr] > 0) {
			Ptr--;
		}
		Ptr++;
		while(Mem[Ptr] > 0) {
			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			while(Mem[Ptr] > 0) {
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			}
			Ptr++;
			while(Mem[Ptr] > 0) {
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			}
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Ptr--;
			Ptr--;
			Ptr--;
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Ptr++;
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Ptr++;
			while(Mem[Ptr] > 0) {
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				while(Mem[Ptr] > 0) {
					Ptr--;
					Ptr--;
					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
					Ptr++;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					Ptr++;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					while(Mem[Ptr] > 0) {
						Ptr--;
						Ptr--;
						while(Mem[Ptr] > 0) {
							Mem[Ptr] = (Mem[Ptr] - 1) % 256;
						}
						Ptr++;
						Ptr++;
						Mem[Ptr] = (Mem[Ptr] - 1) % 256;
						while(Mem[Ptr] > 0) {
							Ptr--;
							Ptr--;
							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
							Ptr++;
							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
							Ptr++;
							Mem[Ptr] = (Mem[Ptr] - 1) % 256;
							while(Mem[Ptr] > 0) {
								Ptr--;
								Ptr--;
								Mem[Ptr] = (Mem[Ptr] - 1) % 256;
								Mem[Ptr] = (Mem[Ptr] - 1) % 256;
								Ptr++;
								Mem[Ptr] = (Mem[Ptr] - 1) % 256;
								Ptr++;
								Ptr++;
								Mem[Ptr] = (Mem[Ptr] + 1) % 256;
								Mem[Ptr] = (Mem[Ptr] + 1) % 256;
								Mem[Ptr] = (Mem[Ptr] + 1) % 256;
								Ptr--;
								Mem[Ptr] = (Mem[Ptr] - 1) % 256;
								while(Mem[Ptr] > 0) {
									Ptr--;
									Ptr--;
									Mem[Ptr] = (Mem[Ptr] + 1) % 256;
									Ptr++;
									Mem[Ptr] = (Mem[Ptr] + 1) % 256;
									Ptr++;
									Ptr++;
									Mem[Ptr] = (Mem[Ptr] - 1) % 256;
									Mem[Ptr] = (Mem[Ptr] - 1) % 256;
									Ptr--;
									Mem[Ptr] = (Mem[Ptr] - 1) % 256;
									while(Mem[Ptr] > 0) {
										Ptr--;
										Ptr--;
										Mem[Ptr] = (Mem[Ptr] - 1) % 256;
										Ptr++;
										Mem[Ptr] = (Mem[Ptr] - 1) % 256;
										Ptr++;
										Mem[Ptr] = (Mem[Ptr] - 1) % 256;
										while(Mem[Ptr] > 0) {
											Ptr--;
											Ptr--;
											Mem[Ptr] = (Mem[Ptr] + 1) % 256;
											Mem[Ptr] = (Mem[Ptr] + 1) % 256;
											Mem[Ptr] = (Mem[Ptr] + 1) % 256;
											Mem[Ptr] = (Mem[Ptr] + 1) % 256;
											Ptr++;
											Mem[Ptr] = (Mem[Ptr] + 1) % 256;
											Ptr++;
											Ptr++;
											Mem[Ptr] = (Mem[Ptr] + 1) % 256;
											Ptr--;
											Mem[Ptr] = (Mem[Ptr] - 1) % 256;
											while(Mem[Ptr] > 0) {
												Ptr++;
												Mem[Ptr] = (Mem[Ptr] - 1) % 256;
												Ptr--;
												Mem[Ptr] = (Mem[Ptr] - 1) % 256;
												while(Mem[Ptr] > 0) {
													Ptr--;
													Ptr--;
													Mem[Ptr] = (Mem[Ptr] - 1) % 256;
													Ptr++;
													Mem[Ptr] = (Mem[Ptr] - 1) % 256;
													Ptr++;
													Mem[Ptr] = (Mem[Ptr] - 1) % 256;
													while(Mem[Ptr] > 0) {
														Ptr--;
														Ptr--;
														Mem[Ptr] = (Mem[Ptr] - 1) % 256;
														Ptr++;
														Ptr++;
														Mem[Ptr] = (Mem[Ptr] - 1) % 256;
														while(Mem[Ptr] > 0) {
															Ptr--;
															Ptr--;
															Mem[Ptr] = (Mem[Ptr] + 1) % 256;
															Mem[Ptr] = (Mem[Ptr] + 1) % 256;
															Mem[Ptr] = (Mem[Ptr] + 1) % 256;
															Ptr++;
															Ptr++;
															Ptr++;
															Mem[Ptr] = (Mem[Ptr] - 1) % 256;
															Ptr--;
															Mem[Ptr] = (Mem[Ptr] - 1) % 256;
															while(Mem[Ptr] > 0) {
																Ptr--;
																Ptr--;
																Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																Ptr++;
																Ptr++;
																Ptr++;
																Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																Ptr--;
																Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																while(Mem[Ptr] > 0) {
																	Ptr--;
																	Ptr--;
																	Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																	Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																	Ptr++;
																	Ptr++;
																	Ptr++;
																	Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																	Ptr--;
																	Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																	while(Mem[Ptr] > 0) {
																		Ptr++;
																		while(Mem[Ptr] > 0) {
																			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																		}
																		Ptr--;
																		Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																		while(Mem[Ptr] > 0) {
																			Ptr--;
																			Ptr--;
																			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																			Ptr++;
																			Ptr++;
																			Ptr++;
																			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																			Ptr--;
																			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																			while(Mem[Ptr] > 0) {
																				Ptr--;
																				Ptr--;
																				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																				Ptr++;
																				Ptr++;
																				Ptr++;
																				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																				Ptr--;
																				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																				while(Mem[Ptr] > 0) {
																					Ptr--;
																					Ptr--;
																					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																					Ptr++;
																					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																					Ptr++;
																					Ptr++;
																					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																					Ptr--;
																					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																					while(Mem[Ptr] > 0) {
																						Ptr--;
																						Ptr--;
																						while(Mem[Ptr] > 0) {
																							Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																						}
																						Ptr++;
																						Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																						Ptr++;
																						Ptr++;
																						Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																						Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																						Ptr--;
																						Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																						while(Mem[Ptr] > 0) {
																							Ptr--;
																							Ptr--;
																							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																							Ptr++;
																							Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																							Ptr++;
																							Ptr++;
																							Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																							Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																							Ptr--;
																							Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																							while(Mem[Ptr] > 0) {
																								Ptr--;
																								Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																								Ptr++;
																								Ptr++;
																								Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																								Mem[Ptr] = (Mem[Ptr] + 1) % 256;
																								Ptr--;
																								while(Mem[Ptr] > 0) {
																									Ptr--;
																									Ptr--;
																									Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																									Ptr++;
																									Ptr++;
																									Mem[Ptr] = (Mem[Ptr] - 1) % 256;
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			Ptr--;
			while(Mem[Ptr] > 0) {
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				Ptr++;
				Ptr++;
				while(Mem[Ptr] > 0) {
					Ptr--;
					Ptr--;
					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
					Ptr++;
					Ptr++;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				}
				Ptr--;
				Ptr--;
				Ptr--;
				while(Mem[Ptr] > 0) {
					Ptr++;
					Ptr++;
					Ptr++;
					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
					Ptr--;
					Ptr--;
					Ptr--;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				}
				Ptr--;
				while(Mem[Ptr] > 0) {
					Ptr++;
					Ptr++;
					Ptr++;
					Mem[Ptr] = (Mem[Ptr] + 1) % 256;
					Ptr--;
					Ptr--;
					Ptr--;
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				}
			}
			Ptr++;
			Ptr++;
		}
		Ptr++;
		while(Mem[Ptr] > 0) {
			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			while(Mem[Ptr] > 0) {
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				while(Mem[Ptr] > 0) {
					Mem[Ptr] = (Mem[Ptr] - 1) % 256;
					Ptr--;
				}
			}
			Ptr++;
		}
		Ptr++;
		while(Mem[Ptr] > 0) {
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			Mem[Ptr] = (Mem[Ptr] + 1) % 256;
			while(Mem[Ptr] > 0) {
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			}
			Ptr++;
		}
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Ptr--;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		Mem[Ptr] = (Mem[Ptr] + 1) % 256;
		while(Mem[Ptr] > 0) {
			while(Mem[Ptr] > 0) {
				Ptr++;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Mem[Ptr] = (Mem[Ptr] + 1) % 256;
				Ptr--;
				Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			}
			Ptr--;
		}
		Ptr++;
		Ptr++;
		while(Mem[Ptr] > 0) {
			Mem[Ptr] = (Mem[Ptr] - 1) % 256;
			System.Console.Write((char)Mem[Ptr]);
			Ptr++;
		}
	}
}
